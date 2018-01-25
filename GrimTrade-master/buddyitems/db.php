<?php


	class db {
		private $_db;

		public function __construct() {
			$this->_db = new PDO('mysql:host=HOSTNAME;dbname=DBNAME', 'USERNAME', 'PASSWORD') or die('DB Error');
		}

		public function getBuddy($id) {
			$prep = $this->_db->prepare('select `uid` as `UserId`, `verification` as `Verification`, `description` as `Description`, `items` as `Items` from `gd_buddyitems` where uid=?');
			$prep->execute(array((int)$id));
			return $prep->fetch(PDO::FETCH_ASSOC);
		}


		public function createUser($uuid) {
			/* Is user in the database already? */
			$prep = $this->_db->prepare('select `uid` from `gd_buddyitems` where `uuid`=?');
			$prep->execute(array($uuid));
			if ($uid = $prep->fetch(PDO::FETCH_ASSOC)) {
				return (int)$uid['uid'];
			}

			/* Generate random number until database says fine */
			$num = mt_rand(1000, 9999);
			while ($this->validNumber($num) > 0) {
				$num = mt_rand(1000, 9999);
			}
			$prep = $this->_db->prepare("insert into `gd_buddyitems` (`uid`, `uuid`) VALUES(?, ?)");
			$prep->execute(array($num, $uuid));
			return $num;
		}

		public function updateItems($args) {
			$args = json_decode(utf8_decode($args['json']), true);
			if (
				array_key_exists('UserId', $args) &&
				array_key_exists('UUID', $args) &&
				array_key_exists('Verification', $args) &&
				array_key_exists('Description', $args) &&
				array_key_exists('Items', $args)
			) {
				$uid = $args['UserId'];
				$uuid = $args['UUID'];
				$verification = $args['Verification'];
				$description = $args['Description'];
				$items = $args['Items'];
				/* Is it a valid uid? */
				if (!$this->validUid($uid, $uuid)) {
                    file_put_contents(__DIR__.'/result.txt', "Nonvalid uid: \n".print_r($args, true));
					return false;
				}
				$prep = $this->_db->prepare('update `gd_buddyitems` set
					 `verification`=:verification,
					`description`=:description,
					`items`=:items
					WHERE
					`uid`=:uid
					AND
					`uuid`=:uuid
				');
				if ($prep->execute(array(
					 ':verification'	=> $verification
					,':description'		=> $description
					,':items'			=> $items
					,':uid'				=> $uid
					,':uuid'			=> $uuid
				))) {
                    file_put_contents(__DIR__.'/result.txt', "went fine");
					return true;
				}
				else {
                    file_put_contents(__DIR__.'/result.txt', print_r($prep->errorInfo(), true));
					return false;
				}

			}
			else {
				echo "Missing params: ";
				print_r($args);
                file_put_contents(__DIR__.'/result.txt', "Missing params: \n".print_r($args, true));
				return false;
			}
		}

		private function validUid($uid, $uuid) {
			$prep = $this->_db->prepare('select `uid` from `gd_buddyitems` where `uid`=? and `uuid`=?');
			$prep->execute(array($uid, $uuid));
			if (count($prep->fetchAll()) == 1) {
				return true;
			}
			return false;
		}


		private function validNumber($number) {
			$prep = $this->_db->prepare('select `uid` from `gd_buddyitems` where `uid`=?');
			$prep->execute(array($number));
			return count($prep->fetchAll());
		}
	}
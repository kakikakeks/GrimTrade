﻿using System.Collections.Generic;

namespace IAGrim.UI.Controller
{
    public class JsonSkill {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual long? Level { get; set; }

        public virtual IList<JsonStat> PetStats { get; set; }
        public virtual IList<JsonStat> HeaderStats { get; set; }
        public virtual IList<JsonStat> BodyStats { get; set; }

        public virtual string Trigger { get; set; }
    }
}

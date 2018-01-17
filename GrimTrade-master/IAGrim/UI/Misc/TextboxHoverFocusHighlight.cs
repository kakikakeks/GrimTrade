﻿using System;
using System.Windows.Forms;

public class TextboxHoverFocusHighlight {
    private TextBoxBase textbox;


    public TextboxHoverFocusHighlight(TextBoxBase textbox) {
        this.textbox = textbox;
        textbox.MouseHover += textboxSearch_MouseHover;
        textbox.GotFocus += textboxSearch_GotFocus;
        textbox.LostFocus += textboxSearch_LostFocus;
        textbox.MouseEnter += textboxSearch_MouseEnter;
        textbox.MouseLeave += textboxSearch_MouseLeave;
    }

    void textboxSearch_MouseLeave(object sender, EventArgs e) {
        if (!this.textbox.Focused)
            this.textbox.BackColor = System.Drawing.SystemColors.Window;
    }

    void textboxSearch_MouseEnter(object sender, EventArgs e) {
        this.textbox.BackColor = System.Drawing.Color.AliceBlue;
    }

    void textboxSearch_MouseHover(object sender, EventArgs e) {
        this.textbox.BackColor = System.Drawing.Color.AliceBlue;
    }

    void textboxSearch_LostFocus(object sender, EventArgs e) {
        this.textbox.BackColor = System.Drawing.SystemColors.Window;
    }

    void textboxSearch_GotFocus(object sender, EventArgs e) {
        this.textbox.BackColor = System.Drawing.Color.AliceBlue;
    }

}
﻿namespace OnlineNeuralNetworkTrainer
{
    partial class SelectDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sdf_main_panel = new System.Windows.Forms.Panel();
            this.sdf_upper_panel = new System.Windows.Forms.Panel();
            this.sdf_selectAll_btn = new System.Windows.Forms.Button();
            this.sdf_confirm_btn = new System.Windows.Forms.Button();
            this.sdf_bot_panel = new System.Windows.Forms.Panel();
            this.sdf_cancel_btn = new System.Windows.Forms.Button();
            this.sdf_main_panel.SuspendLayout();
            this.sdf_upper_panel.SuspendLayout();
            this.sdf_bot_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sdf_main_panel
            // 
            this.sdf_main_panel.Controls.Add(this.sdf_bot_panel);
            this.sdf_main_panel.Controls.Add(this.sdf_upper_panel);
            this.sdf_main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdf_main_panel.Location = new System.Drawing.Point(0, 0);
            this.sdf_main_panel.Name = "sdf_main_panel";
            this.sdf_main_panel.Size = new System.Drawing.Size(463, 365);
            this.sdf_main_panel.TabIndex = 0;
            // 
            // sdf_upper_panel
            // 
            this.sdf_upper_panel.Controls.Add(this.sdf_selectAll_btn);
            this.sdf_upper_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sdf_upper_panel.Location = new System.Drawing.Point(0, 0);
            this.sdf_upper_panel.Name = "sdf_upper_panel";
            this.sdf_upper_panel.Size = new System.Drawing.Size(463, 85);
            this.sdf_upper_panel.TabIndex = 0;
            // 
            // sdf_selectAll_btn
            // 
            this.sdf_selectAll_btn.BackColor = System.Drawing.Color.DarkRed;
            this.sdf_selectAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdf_selectAll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdf_selectAll_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sdf_selectAll_btn.Location = new System.Drawing.Point(140, 26);
            this.sdf_selectAll_btn.Name = "sdf_selectAll_btn";
            this.sdf_selectAll_btn.Size = new System.Drawing.Size(184, 26);
            this.sdf_selectAll_btn.TabIndex = 12;
            this.sdf_selectAll_btn.Text = "Select All Data";
            this.sdf_selectAll_btn.UseVisualStyleBackColor = false;
            this.sdf_selectAll_btn.Click += new System.EventHandler(this.sdf_selectAll_btn_Click);
            // 
            // sdf_confirm_btn
            // 
            this.sdf_confirm_btn.BackColor = System.Drawing.Color.DarkRed;
            this.sdf_confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdf_confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdf_confirm_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sdf_confirm_btn.Location = new System.Drawing.Point(21, 12);
            this.sdf_confirm_btn.Name = "sdf_confirm_btn";
            this.sdf_confirm_btn.Size = new System.Drawing.Size(184, 26);
            this.sdf_confirm_btn.TabIndex = 13;
            this.sdf_confirm_btn.Text = "Confirm";
            this.sdf_confirm_btn.UseVisualStyleBackColor = false;
            this.sdf_confirm_btn.Click += new System.EventHandler(this.sdf_confirm_btn_Click);
            // 
            // sdf_bot_panel
            // 
            this.sdf_bot_panel.Controls.Add(this.sdf_cancel_btn);
            this.sdf_bot_panel.Controls.Add(this.sdf_confirm_btn);
            this.sdf_bot_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sdf_bot_panel.Location = new System.Drawing.Point(0, 315);
            this.sdf_bot_panel.Name = "sdf_bot_panel";
            this.sdf_bot_panel.Size = new System.Drawing.Size(463, 50);
            this.sdf_bot_panel.TabIndex = 14;
            // 
            // sdf_cancel_btn
            // 
            this.sdf_cancel_btn.BackColor = System.Drawing.Color.DarkRed;
            this.sdf_cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdf_cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdf_cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sdf_cancel_btn.Location = new System.Drawing.Point(258, 12);
            this.sdf_cancel_btn.Name = "sdf_cancel_btn";
            this.sdf_cancel_btn.Size = new System.Drawing.Size(184, 26);
            this.sdf_cancel_btn.TabIndex = 14;
            this.sdf_cancel_btn.Text = "Cancel";
            this.sdf_cancel_btn.UseVisualStyleBackColor = false;
            this.sdf_cancel_btn.Click += new System.EventHandler(this.sdf_cancel_btn_Click);
            // 
            // SelectDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 365);
            this.Controls.Add(this.sdf_main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelectDataForm";
            this.Text = "Select Data";
            this.sdf_main_panel.ResumeLayout(false);
            this.sdf_upper_panel.ResumeLayout(false);
            this.sdf_bot_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sdf_main_panel;
        private System.Windows.Forms.Panel sdf_upper_panel;
        private System.Windows.Forms.Panel sdf_bot_panel;
        private System.Windows.Forms.Button sdf_cancel_btn;
        private System.Windows.Forms.Button sdf_confirm_btn;
        private System.Windows.Forms.Button sdf_selectAll_btn;
    }
}
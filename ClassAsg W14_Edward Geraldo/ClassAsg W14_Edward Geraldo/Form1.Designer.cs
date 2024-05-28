namespace ClassAsg_W14_Edward_Geraldo
{
    partial class mainForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tb_matchID = new System.Windows.Forms.TextBox();
            this.cbox_home = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_player = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_away = new System.Windows.Forms.ComboBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.dateTimePickers = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_team = new System.Windows.Forms.ComboBox();
            this.tb_minute = new System.Windows.Forms.TextBox();
            this.cbox_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(59, 365);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 82;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(677, 372);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // tb_matchID
            // 
            this.tb_matchID.Location = new System.Drawing.Point(218, 97);
            this.tb_matchID.Name = "tb_matchID";
            this.tb_matchID.Size = new System.Drawing.Size(306, 31);
            this.tb_matchID.TabIndex = 1;
            // 
            // cbox_home
            // 
            this.cbox_home.FormattingEnabled = true;
            this.cbox_home.Location = new System.Drawing.Point(218, 212);
            this.cbox_home.Name = "cbox_home";
            this.cbox_home.Size = new System.Drawing.Size(306, 33);
            this.cbox_home.TabIndex = 2;
            this.cbox_home.SelectedIndexChanged += new System.EventHandler(this.cbox_home_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Match ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team Home";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Match Date";
            // 
            // cbox_player
            // 
            this.cbox_player.FormattingEnabled = true;
            this.cbox_player.Location = new System.Drawing.Point(1099, 522);
            this.cbox_player.Name = "cbox_player";
            this.cbox_player.Size = new System.Drawing.Size(306, 33);
            this.cbox_player.TabIndex = 5;
            this.cbox_player.SelectedIndexChanged += new System.EventHandler(this.cbox_player_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Team Away";
            // 
            // cbox_away
            // 
            this.cbox_away.FormattingEnabled = true;
            this.cbox_away.Location = new System.Drawing.Point(930, 215);
            this.cbox_away.Name = "cbox_away";
            this.cbox_away.Size = new System.Drawing.Size(306, 33);
            this.cbox_away.TabIndex = 7;
            this.cbox_away.SelectedIndexChanged += new System.EventHandler(this.cbox_away_SelectedIndexChanged);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(655, 781);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(235, 46);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // dateTimePickers
            // 
            this.dateTimePickers.Location = new System.Drawing.Point(930, 95);
            this.dateTimePickers.Name = "dateTimePickers";
            this.dateTimePickers.Size = new System.Drawing.Size(392, 31);
            this.dateTimePickers.TabIndex = 10;
            this.dateTimePickers.ValueChanged += new System.EventHandler(this.dateTimePickers_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(871, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Team ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(871, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Minute";
            // 
            // cbox_team
            // 
            this.cbox_team.FormattingEnabled = true;
            this.cbox_team.Location = new System.Drawing.Point(1099, 453);
            this.cbox_team.Name = "cbox_team";
            this.cbox_team.Size = new System.Drawing.Size(306, 33);
            this.cbox_team.TabIndex = 12;
            this.cbox_team.SelectedIndexChanged += new System.EventHandler(this.cbox_team_SelectedIndexChanged);
            // 
            // tb_minute
            // 
            this.tb_minute.Location = new System.Drawing.Point(1099, 392);
            this.tb_minute.Name = "tb_minute";
            this.tb_minute.Size = new System.Drawing.Size(306, 31);
            this.tb_minute.TabIndex = 11;
            // 
            // cbox_type
            // 
            this.cbox_type.FormattingEnabled = true;
            this.cbox_type.Items.AddRange(new object[] {
            "GO",
            "GP ",
            "GW ",
            "CR",
            "CY ",
            "PM"});
            this.cbox_type.Location = new System.Drawing.Point(1099, 584);
            this.cbox_type.Name = "cbox_type";
            this.cbox_type.Size = new System.Drawing.Size(306, 33);
            this.cbox_type.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(871, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Player";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(871, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Type";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(988, 656);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(235, 46);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(1268, 656);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(235, 46);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 909);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbox_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbox_team);
            this.Controls.Add(this.tb_minute);
            this.Controls.Add(this.dateTimePickers);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_away);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox_player);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_home);
            this.Controls.Add(this.tb_matchID);
            this.Controls.Add(this.dgv);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tb_matchID;
        private System.Windows.Forms.ComboBox cbox_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox_player;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_away;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DateTimePicker dateTimePickers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbox_team;
        private System.Windows.Forms.TextBox tb_minute;
        private System.Windows.Forms.ComboBox cbox_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
    }
}


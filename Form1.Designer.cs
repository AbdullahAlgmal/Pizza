namespace My_Pizza
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOrder = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbtLarg = new System.Windows.Forms.RadioButton();
            this.rbtMeduim = new System.Windows.Forms.RadioButton();
            this.rbtSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbtThick = new System.Windows.Forms.RadioButton();
            this.rbtThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chGreen = new System.Windows.Forms.CheckBox();
            this.chOlives = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.chTomatoes = new System.Windows.Forms.CheckBox();
            this.chMush = new System.Windows.Forms.CheckBox();
            this.chExtra = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbtOut = new System.Windows.Forms.RadioButton();
            this.rbtIn = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblWhere = new System.Windows.Forms.Label();
            this.lblThin = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ImageLocation = "E:\\Programs\\Design\\10336107_18514975.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(984, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAKE YOUR PIZZA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btOrder
            // 
            this.btOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btOrder.BackColor = System.Drawing.Color.Gold;
            this.btOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrder.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.ForeColor = System.Drawing.Color.IndianRed;
            this.btOrder.Location = new System.Drawing.Point(340, 464);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(120, 50);
            this.btOrder.TabIndex = 2;
            this.btOrder.Text = "Order Pizza";
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // btReset
            // 
            this.btReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btReset.BackColor = System.Drawing.Color.Gold;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReset.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.Color.IndianRed;
            this.btReset.Location = new System.Drawing.Point(525, 464);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(120, 50);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "Reset Form";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Gold;
            this.gbSize.Controls.Add(this.rbtLarg);
            this.gbSize.Controls.Add(this.rbtMeduim);
            this.gbSize.Controls.Add(this.rbtSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.ForeColor = System.Drawing.Color.IndianRed;
            this.gbSize.Location = new System.Drawing.Point(15, 75);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(150, 210);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbtLarg
            // 
            this.rbtLarg.AutoSize = true;
            this.rbtLarg.Location = new System.Drawing.Point(13, 166);
            this.rbtLarg.Name = "rbtLarg";
            this.rbtLarg.Size = new System.Drawing.Size(62, 27);
            this.rbtLarg.TabIndex = 2;
            this.rbtLarg.TabStop = true;
            this.rbtLarg.Tag = "15";
            this.rbtLarg.Text = "Larg";
            this.rbtLarg.UseVisualStyleBackColor = true;
            this.rbtLarg.CheckedChanged += new System.EventHandler(this.Size_CheckedChanged);
            // 
            // rbtMeduim
            // 
            this.rbtMeduim.AutoSize = true;
            this.rbtMeduim.Location = new System.Drawing.Point(13, 102);
            this.rbtMeduim.Name = "rbtMeduim";
            this.rbtMeduim.Size = new System.Drawing.Size(84, 27);
            this.rbtMeduim.TabIndex = 1;
            this.rbtMeduim.TabStop = true;
            this.rbtMeduim.Tag = "10";
            this.rbtMeduim.Text = "Meduim";
            this.rbtMeduim.UseVisualStyleBackColor = true;
            this.rbtMeduim.CheckedChanged += new System.EventHandler(this.Size_CheckedChanged);
            // 
            // rbtSmall
            // 
            this.rbtSmall.AutoSize = true;
            this.rbtSmall.Location = new System.Drawing.Point(16, 38);
            this.rbtSmall.Name = "rbtSmall";
            this.rbtSmall.Size = new System.Drawing.Size(67, 27);
            this.rbtSmall.TabIndex = 0;
            this.rbtSmall.TabStop = true;
            this.rbtSmall.Tag = "5";
            this.rbtSmall.Text = "Small";
            this.rbtSmall.UseVisualStyleBackColor = true;
            this.rbtSmall.CheckedChanged += new System.EventHandler(this.Size_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.Gold;
            this.gbCrust.Controls.Add(this.rbtThick);
            this.gbCrust.Controls.Add(this.rbtThin);
            this.gbCrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCrust.ForeColor = System.Drawing.Color.IndianRed;
            this.gbCrust.Location = new System.Drawing.Point(15, 291);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(150, 140);
            this.gbCrust.TabIndex = 5;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rbtThick
            // 
            this.rbtThick.AutoSize = true;
            this.rbtThick.Location = new System.Drawing.Point(13, 102);
            this.rbtThick.Name = "rbtThick";
            this.rbtThick.Size = new System.Drawing.Size(116, 27);
            this.rbtThick.TabIndex = 1;
            this.rbtThick.TabStop = true;
            this.rbtThick.Tag = "10";
            this.rbtThick.Text = "Thick Crust";
            this.rbtThick.UseVisualStyleBackColor = true;
            this.rbtThick.CheckedChanged += new System.EventHandler(this.CrustType_CheckedChanged);
            // 
            // rbtThin
            // 
            this.rbtThin.AutoSize = true;
            this.rbtThin.Location = new System.Drawing.Point(16, 38);
            this.rbtThin.Name = "rbtThin";
            this.rbtThin.Size = new System.Drawing.Size(107, 27);
            this.rbtThin.TabIndex = 0;
            this.rbtThin.TabStop = true;
            this.rbtThin.Tag = "5";
            this.rbtThin.Text = "Thin Crust";
            this.rbtThin.UseVisualStyleBackColor = true;
            this.rbtThin.CheckedChanged += new System.EventHandler(this.CrustType_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbToppings.BackColor = System.Drawing.Color.Gold;
            this.gbToppings.Controls.Add(this.chGreen);
            this.gbToppings.Controls.Add(this.chOlives);
            this.gbToppings.Controls.Add(this.chOnion);
            this.gbToppings.Controls.Add(this.chTomatoes);
            this.gbToppings.Controls.Add(this.chMush);
            this.gbToppings.Controls.Add(this.chExtra);
            this.gbToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbToppings.ForeColor = System.Drawing.Color.IndianRed;
            this.gbToppings.Location = new System.Drawing.Point(345, 75);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(300, 210);
            this.gbToppings.TabIndex = 6;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chGreen
            // 
            this.chGreen.AutoSize = true;
            this.chGreen.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chGreen.Location = new System.Drawing.Point(161, 167);
            this.chGreen.Name = "chGreen";
            this.chGreen.Size = new System.Drawing.Size(128, 26);
            this.chGreen.TabIndex = 11;
            this.chGreen.Tag = "5";
            this.chGreen.Text = "Green Peppers";
            this.chGreen.UseVisualStyleBackColor = true;
            this.chGreen.CheckedChanged += new System.EventHandler(this.Toppings_CheckedChanged);
            // 
            // chOlives
            // 
            this.chOlives.AutoSize = true;
            this.chOlives.Location = new System.Drawing.Point(161, 102);
            this.chOlives.Name = "chOlives";
            this.chOlives.Size = new System.Drawing.Size(75, 27);
            this.chOlives.TabIndex = 10;
            this.chOlives.Tag = "5";
            this.chOlives.Text = "Olives";
            this.chOlives.UseVisualStyleBackColor = true;
            this.chOlives.CheckedChanged += new System.EventHandler(this.Toppings_CheckedChanged);
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.Location = new System.Drawing.Point(161, 39);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(70, 27);
            this.chOnion.TabIndex = 9;
            this.chOnion.Tag = "5";
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.Toppings_CheckedChanged);
            // 
            // chTomatoes
            // 
            this.chTomatoes.AutoSize = true;
            this.chTomatoes.Location = new System.Drawing.Point(16, 166);
            this.chTomatoes.Name = "chTomatoes";
            this.chTomatoes.Size = new System.Drawing.Size(101, 27);
            this.chTomatoes.TabIndex = 8;
            this.chTomatoes.Tag = "5";
            this.chTomatoes.Text = "Tomatoes";
            this.chTomatoes.UseVisualStyleBackColor = true;
            this.chTomatoes.CheckedChanged += new System.EventHandler(this.Toppings_CheckedChanged);
            // 
            // chMush
            // 
            this.chMush.AutoSize = true;
            this.chMush.Location = new System.Drawing.Point(16, 102);
            this.chMush.Name = "chMush";
            this.chMush.Size = new System.Drawing.Size(112, 27);
            this.chMush.TabIndex = 7;
            this.chMush.Tag = "5";
            this.chMush.Text = "Mushrooms";
            this.chMush.UseVisualStyleBackColor = true;
            this.chMush.CheckedChanged += new System.EventHandler(this.Toppings_CheckedChanged);
            // 
            // chExtra
            // 
            this.chExtra.AutoSize = true;
            this.chExtra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chExtra.Location = new System.Drawing.Point(16, 38);
            this.chExtra.Name = "chExtra";
            this.chExtra.Size = new System.Drawing.Size(122, 27);
            this.chExtra.TabIndex = 6;
            this.chExtra.Tag = "5";
            this.chExtra.Text = "Extra Chees";
            this.chExtra.UseVisualStyleBackColor = true;
            this.chExtra.CheckedChanged += new System.EventHandler(this.Toppings_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbWhereToEat.BackColor = System.Drawing.Color.Gold;
            this.gbWhereToEat.Controls.Add(this.rbtOut);
            this.gbWhereToEat.Controls.Add(this.rbtIn);
            this.gbWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWhereToEat.ForeColor = System.Drawing.Color.IndianRed;
            this.gbWhereToEat.Location = new System.Drawing.Point(343, 360);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(300, 70);
            this.gbWhereToEat.TabIndex = 7;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbtOut
            // 
            this.rbtOut.AutoSize = true;
            this.rbtOut.Location = new System.Drawing.Point(163, 38);
            this.rbtOut.Name = "rbtOut";
            this.rbtOut.Size = new System.Drawing.Size(99, 27);
            this.rbtOut.TabIndex = 1;
            this.rbtOut.TabStop = true;
            this.rbtOut.Tag = "0";
            this.rbtOut.Text = "Take Out";
            this.rbtOut.UseVisualStyleBackColor = true;
            this.rbtOut.CheckedChanged += new System.EventHandler(this.WhereToEat_CheckedChanged);
            // 
            // rbtIn
            // 
            this.rbtIn.AutoSize = true;
            this.rbtIn.Location = new System.Drawing.Point(16, 38);
            this.rbtIn.Name = "rbtIn";
            this.rbtIn.Size = new System.Drawing.Size(76, 27);
            this.rbtIn.TabIndex = 0;
            this.rbtIn.TabStop = true;
            this.rbtIn.Tag = "0";
            this.rbtIn.Text = "Eat In";
            this.rbtIn.UseVisualStyleBackColor = true;
            this.rbtIn.CheckedChanged += new System.EventHandler(this.WhereToEat_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.Gold;
            this.groupBox5.Controls.Add(this.lblWhere);
            this.groupBox5.Controls.Add(this.lblThin);
            this.groupBox5.Controls.Add(this.lblToppings);
            this.groupBox5.Controls.Add(this.lblSize);
            this.groupBox5.Controls.Add(this.lblSalary);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox5.Location = new System.Drawing.Point(668, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 356);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order Summary";
            // 
            // lblWhere
            // 
            this.lblWhere.AutoSize = true;
            this.lblWhere.Location = new System.Drawing.Point(151, 216);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(58, 23);
            this.lblWhere.TabIndex = 9;
            this.lblWhere.Text = "Eat In";
            // 
            // lblThin
            // 
            this.lblThin.AutoSize = true;
            this.lblThin.Location = new System.Drawing.Point(126, 187);
            this.lblThin.Name = "lblThin";
            this.lblThin.Size = new System.Drawing.Size(89, 23);
            this.lblThin.TabIndex = 8;
            this.lblThin.Text = "Thin Crust";
            // 
            // lblToppings
            // 
            this.lblToppings.Location = new System.Drawing.Point(30, 115);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(264, 72);
            this.lblToppings.TabIndex = 7;
            this.lblToppings.Text = "No Toppings";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(72, 38);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(49, 23);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Small";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Green;
            this.lblSalary.Location = new System.Drawing.Point(193, 293);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(71, 52);
            this.lblSalary.TabIndex = 5;
            this.lblSalary.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Where To Eat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Crust Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toppings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 526);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbtLarg;
        private System.Windows.Forms.RadioButton rbtMeduim;
        private System.Windows.Forms.RadioButton rbtSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbtThick;
        private System.Windows.Forms.RadioButton rbtThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chExtra;
        private System.Windows.Forms.CheckBox chGreen;
        private System.Windows.Forms.CheckBox chOlives;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.CheckBox chTomatoes;
        private System.Windows.Forms.CheckBox chMush;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbtOut;
        private System.Windows.Forms.RadioButton rbtIn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.Label lblThin;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSize;
    }
}


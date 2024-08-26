namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdsizelarge = new System.Windows.Forms.RadioButton();
            this.srSizeMediem = new System.Windows.Forms.RadioButton();
            this.rdSizesmall = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdThincrust = new System.Windows.Forms.RadioButton();
            this.rdThinkcrust = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdeatin = new System.Windows.Forms.RadioButton();
            this.rdtakeout = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chktoppingpeppers = new System.Windows.Forms.CheckBox();
            this.chktppingolves = new System.Windows.Forms.CheckBox();
            this.chktoppingonion = new System.Windows.Forms.CheckBox();
            this.chktoppingtomatoes = new System.Windows.Forms.CheckBox();
            this.chktoppingmushroom = new System.Windows.Forms.CheckBox();
            this.chktoppingcheese = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsize = new System.Windows.Forms.Label();
            this.txttopping = new System.Windows.Forms.Label();
            this.txtcrusttype = new System.Windows.Forms.Label();
            this.txtwheretoeat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(88, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = " $20";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdsizelarge);
            this.groupBox1.Controls.Add(this.srSizeMediem);
            this.groupBox1.Controls.Add(this.rdSizesmall);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(183, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdsizelarge
            // 
            this.rdsizelarge.AutoSize = true;
            this.rdsizelarge.ForeColor = System.Drawing.Color.White;
            this.rdsizelarge.Location = new System.Drawing.Point(25, 102);
            this.rdsizelarge.Name = "rdsizelarge";
            this.rdsizelarge.Size = new System.Drawing.Size(66, 22);
            this.rdsizelarge.TabIndex = 2;
            this.rdsizelarge.TabStop = true;
            this.rdsizelarge.Text = "Large";
            this.rdsizelarge.UseVisualStyleBackColor = true;
            this.rdsizelarge.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // srSizeMediem
            // 
            this.srSizeMediem.AutoSize = true;
            this.srSizeMediem.ForeColor = System.Drawing.Color.White;
            this.srSizeMediem.Location = new System.Drawing.Point(25, 69);
            this.srSizeMediem.Name = "srSizeMediem";
            this.srSizeMediem.Size = new System.Drawing.Size(82, 22);
            this.srSizeMediem.TabIndex = 1;
            this.srSizeMediem.TabStop = true;
            this.srSizeMediem.Text = "Mediem";
            this.srSizeMediem.UseVisualStyleBackColor = true;
            this.srSizeMediem.CheckedChanged += new System.EventHandler(this.srSizeMediem_CheckedChanged);
            // 
            // rdSizesmall
            // 
            this.rdSizesmall.AutoSize = true;
            this.rdSizesmall.ForeColor = System.Drawing.Color.White;
            this.rdSizesmall.Location = new System.Drawing.Point(25, 34);
            this.rdSizesmall.Name = "rdSizesmall";
            this.rdSizesmall.Size = new System.Drawing.Size(66, 22);
            this.rdSizesmall.TabIndex = 0;
            this.rdSizesmall.TabStop = true;
            this.rdSizesmall.Text = "Small";
            this.rdSizesmall.UseVisualStyleBackColor = true;
            this.rdSizesmall.CheckedChanged += new System.EventHandler(this.rdSizesmall_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(306, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(796, 98);
            this.label2.TabIndex = 4;
            this.label2.Text = "MAKE YOUR PIZZA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdThincrust);
            this.groupBox2.Controls.Add(this.rdThinkcrust);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(183, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 108);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust Type";
            // 
            // rdThincrust
            // 
            this.rdThincrust.AutoSize = true;
            this.rdThincrust.ForeColor = System.Drawing.Color.White;
            this.rdThincrust.Location = new System.Drawing.Point(25, 36);
            this.rdThincrust.Name = "rdThincrust";
            this.rdThincrust.Size = new System.Drawing.Size(97, 22);
            this.rdThincrust.TabIndex = 1;
            this.rdThincrust.Tag = "10";
            this.rdThincrust.Text = "Thin Crust";
            this.rdThincrust.UseVisualStyleBackColor = true;
            this.rdThincrust.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // rdThinkcrust
            // 
            this.rdThinkcrust.AutoSize = true;
            this.rdThinkcrust.ForeColor = System.Drawing.Color.White;
            this.rdThinkcrust.Location = new System.Drawing.Point(25, 80);
            this.rdThinkcrust.Name = "rdThinkcrust";
            this.rdThinkcrust.Size = new System.Drawing.Size(105, 22);
            this.rdThinkcrust.TabIndex = 3;
            this.rdThinkcrust.Tag = "10";
            this.rdThinkcrust.Text = "Think Crust";
            this.rdThinkcrust.UseVisualStyleBackColor = true;
            this.rdThinkcrust.CheckedChanged += new System.EventHandler(this.rdThinkcrust_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rdeatin);
            this.groupBox3.Controls.Add(this.rdtakeout);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(523, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 75);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Where To Eat";
            // 
            // rdeatin
            // 
            this.rdeatin.AutoSize = true;
            this.rdeatin.ForeColor = System.Drawing.Color.White;
            this.rdeatin.Location = new System.Drawing.Point(35, 37);
            this.rdeatin.Name = "rdeatin";
            this.rdeatin.Size = new System.Drawing.Size(66, 22);
            this.rdeatin.TabIndex = 1;
            this.rdeatin.Tag = "10";
            this.rdeatin.Text = "Eat in";
            this.rdeatin.UseVisualStyleBackColor = true;
            this.rdeatin.CheckedChanged += new System.EventHandler(this.rdeatin_CheckedChanged);
            // 
            // rdtakeout
            // 
            this.rdtakeout.AutoSize = true;
            this.rdtakeout.ForeColor = System.Drawing.Color.White;
            this.rdtakeout.Location = new System.Drawing.Point(171, 37);
            this.rdtakeout.Name = "rdtakeout";
            this.rdtakeout.Size = new System.Drawing.Size(90, 22);
            this.rdtakeout.TabIndex = 3;
            this.rdtakeout.Tag = "10";
            this.rdtakeout.Text = "Take Out";
            this.rdtakeout.UseVisualStyleBackColor = true;
            this.rdtakeout.CheckedChanged += new System.EventHandler(this.rdtakeout_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.chktoppingpeppers);
            this.groupBox4.Controls.Add(this.chktppingolves);
            this.groupBox4.Controls.Add(this.chktoppingonion);
            this.groupBox4.Controls.Add(this.chktoppingtomatoes);
            this.groupBox4.Controls.Add(this.chktoppingmushroom);
            this.groupBox4.Controls.Add(this.chktoppingcheese);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(514, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 129);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Toppings";
            // 
            // chktoppingpeppers
            // 
            this.chktoppingpeppers.AutoSize = true;
            this.chktoppingpeppers.ForeColor = System.Drawing.Color.White;
            this.chktoppingpeppers.Location = new System.Drawing.Point(166, 103);
            this.chktoppingpeppers.Name = "chktoppingpeppers";
            this.chktoppingpeppers.Size = new System.Drawing.Size(130, 22);
            this.chktoppingpeppers.TabIndex = 5;
            this.chktoppingpeppers.Text = "Green Peppers";
            this.chktoppingpeppers.UseVisualStyleBackColor = true;
            this.chktoppingpeppers.CheckedChanged += new System.EventHandler(this.chktoppingpeppers_CheckedChanged);
            // 
            // chktppingolves
            // 
            this.chktppingolves.AutoSize = true;
            this.chktppingolves.ForeColor = System.Drawing.Color.White;
            this.chktppingolves.Location = new System.Drawing.Point(166, 70);
            this.chktppingolves.Name = "chktppingolves";
            this.chktppingolves.Size = new System.Drawing.Size(76, 22);
            this.chktppingolves.TabIndex = 4;
            this.chktppingolves.Text = "Oleves";
            this.chktppingolves.UseVisualStyleBackColor = true;
            this.chktppingolves.CheckedChanged += new System.EventHandler(this.chktppingolves_CheckedChanged);
            // 
            // chktoppingonion
            // 
            this.chktoppingonion.AutoSize = true;
            this.chktoppingonion.ForeColor = System.Drawing.Color.White;
            this.chktoppingonion.Location = new System.Drawing.Point(166, 34);
            this.chktoppingonion.Name = "chktoppingonion";
            this.chktoppingonion.Size = new System.Drawing.Size(70, 22);
            this.chktoppingonion.TabIndex = 3;
            this.chktoppingonion.Text = "Onion";
            this.chktoppingonion.UseVisualStyleBackColor = true;
            this.chktoppingonion.CheckedChanged += new System.EventHandler(this.chktoppingonion_CheckedChanged);
            // 
            // chktoppingtomatoes
            // 
            this.chktoppingtomatoes.AutoSize = true;
            this.chktoppingtomatoes.ForeColor = System.Drawing.Color.White;
            this.chktoppingtomatoes.Location = new System.Drawing.Point(10, 103);
            this.chktoppingtomatoes.Name = "chktoppingtomatoes";
            this.chktoppingtomatoes.Size = new System.Drawing.Size(98, 22);
            this.chktoppingtomatoes.TabIndex = 2;
            this.chktoppingtomatoes.Text = "Tomatoes";
            this.chktoppingtomatoes.UseVisualStyleBackColor = true;
            this.chktoppingtomatoes.CheckedChanged += new System.EventHandler(this.chktoppingtomatoes_CheckedChanged);
            // 
            // chktoppingmushroom
            // 
            this.chktoppingmushroom.AutoSize = true;
            this.chktoppingmushroom.ForeColor = System.Drawing.Color.White;
            this.chktoppingmushroom.Location = new System.Drawing.Point(10, 70);
            this.chktoppingmushroom.Name = "chktoppingmushroom";
            this.chktoppingmushroom.Size = new System.Drawing.Size(111, 22);
            this.chktoppingmushroom.TabIndex = 1;
            this.chktoppingmushroom.Text = "Mushrooms";
            this.chktoppingmushroom.UseVisualStyleBackColor = true;
            this.chktoppingmushroom.CheckedChanged += new System.EventHandler(this.chktoppingmushroom_CheckedChanged);
            // 
            // chktoppingcheese
            // 
            this.chktoppingcheese.AutoSize = true;
            this.chktoppingcheese.ForeColor = System.Drawing.Color.White;
            this.chktoppingcheese.Location = new System.Drawing.Point(10, 34);
            this.chktoppingcheese.Name = "chktoppingcheese";
            this.chktoppingcheese.Size = new System.Drawing.Size(119, 22);
            this.chktoppingcheese.TabIndex = 0;
            this.chktoppingcheese.Text = "Extra Cheese";
            this.chktoppingcheese.UseVisualStyleBackColor = true;
            this.chktoppingcheese.CheckedChanged += new System.EventHandler(this.chktoppingcheese_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1084, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Order Summry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Toppings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Crust Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(7, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Where To Eat:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtsize
            // 
            this.txtsize.AutoSize = true;
            this.txtsize.BackColor = System.Drawing.Color.Transparent;
            this.txtsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtsize.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtsize.Location = new System.Drawing.Point(58, 19);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(45, 18);
            this.txtsize.TabIndex = 13;
            this.txtsize.Text = "Small";
            this.txtsize.Click += new System.EventHandler(this.txtsize_Click);
            // 
            // txttopping
            // 
            this.txttopping.BackColor = System.Drawing.Color.Transparent;
            this.txttopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txttopping.ForeColor = System.Drawing.Color.DarkOrange;
            this.txttopping.Location = new System.Drawing.Point(61, 77);
            this.txttopping.Name = "txttopping";
            this.txttopping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txttopping.Size = new System.Drawing.Size(210, 65);
            this.txttopping.TabIndex = 14;
            this.txttopping.Text = "Extra Cheese,Mushroom";
            // 
            // txtcrusttype
            // 
            this.txtcrusttype.AutoSize = true;
            this.txtcrusttype.BackColor = System.Drawing.Color.Transparent;
            this.txtcrusttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcrusttype.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtcrusttype.Location = new System.Drawing.Point(119, 142);
            this.txtcrusttype.Name = "txtcrusttype";
            this.txtcrusttype.Size = new System.Drawing.Size(31, 18);
            this.txtcrusttype.TabIndex = 15;
            this.txtcrusttype.Text = "thin";
            // 
            // txtwheretoeat
            // 
            this.txtwheretoeat.AutoSize = true;
            this.txtwheretoeat.BackColor = System.Drawing.Color.Transparent;
            this.txtwheretoeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtwheretoeat.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtwheretoeat.Location = new System.Drawing.Point(107, 207);
            this.txtwheretoeat.Name = "txtwheretoeat";
            this.txtwheretoeat.Size = new System.Drawing.Size(43, 18);
            this.txtwheretoeat.TabIndex = 16;
            this.txtwheretoeat.Text = "eat in";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Price: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(492, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Order Pizza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(726, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtsize);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txttopping);
            this.groupBox5.Controls.Add(this.txtwheretoeat);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtcrusttype);
            this.groupBox5.Location = new System.Drawing.Point(1122, 196);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 243);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(1122, 472);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(181, 97);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1405, 723);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdThincrust;
        private System.Windows.Forms.RadioButton rdThinkcrust;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdeatin;
        private System.Windows.Forms.RadioButton rdtakeout;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chktoppingpeppers;
        private System.Windows.Forms.CheckBox chktppingolves;
        private System.Windows.Forms.CheckBox chktoppingonion;
        private System.Windows.Forms.CheckBox chktoppingtomatoes;
        private System.Windows.Forms.CheckBox chktoppingmushroom;
        private System.Windows.Forms.CheckBox chktoppingcheese;
        private System.Windows.Forms.RadioButton rdsizelarge;
        private System.Windows.Forms.RadioButton srSizeMediem;
        private System.Windows.Forms.RadioButton rdSizesmall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtsize;
        private System.Windows.Forms.Label txttopping;
        private System.Windows.Forms.Label txtcrusttype;
        private System.Windows.Forms.Label txtwheretoeat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}
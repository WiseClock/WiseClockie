namespace WiseClockieTester
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
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Action", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("FPS", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "21",
            "22"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Node8", new System.Windows.Forms.TreeNode[] {
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode43});
            WiseCorner wiseCorner13 = new WiseCorner();
            WiseCorner wiseCorner14 = new WiseCorner();
            WiseCorner wiseCorner15 = new WiseCorner();
            WiseCorner wiseCorner16 = new WiseCorner();
            this.wiseListBox1 = new WiseClockie.Forms.WiseListBox();
            this.wiseProgressBar3 = new WiseClockie.Forms.WiseProgressBar();
            this.wiseCheckBox1 = new WiseClockie.Forms.WiseCheckBox();
            this.wiseListView1 = new WiseClockie.Forms.WiseListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wiseTreeView1 = new WiseClockie.Forms.WiseTreeView();
            this.wiseButton4 = new WiseClockie.Forms.WiseButton();
            this.wiseButton3 = new WiseClockie.Forms.WiseButton();
            this.wiseButton2 = new WiseClockie.Forms.WiseButton();
            this.wiseProgressBar2 = new WiseClockie.Forms.WiseProgressBar();
            this.wiseProgressBar1 = new WiseClockie.Forms.WiseProgressBar();
            this.wiseButton1 = new WiseClockie.Forms.WiseButton();
            this.SuspendLayout();
            // 
            // wiseListBox1
            // 
            this.wiseListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.wiseListBox1.FormattingEnabled = true;
            this.wiseListBox1.GradientColorStrip2 = System.Drawing.Color.Blue;
            this.wiseListBox1.Items.AddRange(new object[] {
            "dfgsdfgsfdg",
            "sdfgdfg",
            "dsgfsdfg"});
            this.wiseListBox1.Location = new System.Drawing.Point(320, 44);
            this.wiseListBox1.Name = "wiseListBox1";
            this.wiseListBox1.Size = new System.Drawing.Size(101, 148);
            this.wiseListBox1.TabIndex = 13;
            // 
            // wiseProgressBar3
            // 
            this.wiseProgressBar3.Animated = true;
            this.wiseProgressBar3.BorderColor = System.Drawing.Color.Black;
            this.wiseProgressBar3.Gradient = true;
            this.wiseProgressBar3.Location = new System.Drawing.Point(219, 12);
            this.wiseProgressBar3.Name = "wiseProgressBar3";
            this.wiseProgressBar3.Size = new System.Drawing.Size(201, 26);
            this.wiseProgressBar3.SolidColor = System.Drawing.Color.Red;
            this.wiseProgressBar3.TabIndex = 12;
            this.wiseProgressBar3.Value = 50;
            this.wiseProgressBar3.VerticalGradient = false;
            // 
            // wiseCheckBox1
            // 
            this.wiseCheckBox1.AutoSize = true;
            this.wiseCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wiseCheckBox1.Location = new System.Drawing.Point(220, 199);
            this.wiseCheckBox1.Name = "wiseCheckBox1";
            this.wiseCheckBox1.Size = new System.Drawing.Size(113, 19);
            this.wiseCheckBox1.TabIndex = 9;
            this.wiseCheckBox1.Text = "wiseCheckBox1";
            this.wiseCheckBox1.UseVisualStyleBackColor = true;
            // 
            // wiseListView1
            // 
            this.wiseListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.wiseListView1.FullRowSelect = true;
            listViewGroup7.Header = "Action";
            listViewGroup7.Name = "listViewGroup1";
            listViewGroup8.Header = "FPS";
            listViewGroup8.Name = "listViewGroup2";
            this.wiseListView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7,
            listViewGroup8});
            listViewItem14.Group = listViewGroup7;
            listViewItem15.Group = listViewGroup7;
            listViewItem16.Group = listViewGroup7;
            this.wiseListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.wiseListView1.Location = new System.Drawing.Point(12, 103);
            this.wiseListView1.Name = "wiseListView1";
            this.wiseListView1.Size = new System.Drawing.Size(201, 238);
            this.wiseListView1.TabIndex = 7;
            this.wiseListView1.UseCompatibleStateImageBehavior = false;
            this.wiseListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cates";
            // 
            // wiseTreeView1
            // 
            this.wiseTreeView1.FullRowSelect = true;
            this.wiseTreeView1.HotTracking = true;
            this.wiseTreeView1.Location = new System.Drawing.Point(220, 44);
            this.wiseTreeView1.Name = "wiseTreeView1";
            treeNode34.Name = "Node7";
            treeNode34.Text = "Node7";
            treeNode35.Name = "Node10";
            treeNode35.Text = "Node10";
            treeNode36.Name = "Node8";
            treeNode36.Text = "Node8";
            treeNode37.Name = "Node9";
            treeNode37.Text = "Node9";
            treeNode38.Name = "Node0";
            treeNode38.Text = "Node0";
            treeNode39.Name = "Node3";
            treeNode39.Text = "Node3";
            treeNode40.Name = "Node4";
            treeNode40.Text = "Node4";
            treeNode41.Name = "Node5";
            treeNode41.Text = "Node5";
            treeNode42.Name = "Node6";
            treeNode42.Text = "Node6";
            treeNode43.Name = "Node2";
            treeNode43.Text = "Node2";
            treeNode44.Name = "Node1";
            treeNode44.Text = "Node1";
            this.wiseTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode44});
            this.wiseTreeView1.Size = new System.Drawing.Size(94, 149);
            this.wiseTreeView1.TabIndex = 6;
            // 
            // wiseButton4
            // 
            wiseCorner13.All = -1;
            wiseCorner13.BottomLeft = 0;
            wiseCorner13.BottomRight = 15;
            wiseCorner13.TopLeft = 0;
            wiseCorner13.TopRight = 15;
            this.wiseButton4.CornerRadius = wiseCorner13;
            this.wiseButton4.Location = new System.Drawing.Point(43, 48);
            this.wiseButton4.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.wiseButton4.Name = "wiseButton4";
            this.wiseButton4.Size = new System.Drawing.Size(90, 47);
            this.wiseButton4.SolidColorDown = System.Drawing.Color.LightBlue;
            this.wiseButton4.SolidColorHover = System.Drawing.Color.LightBlue;
            this.wiseButton4.SolidColorNormal = System.Drawing.Color.LightBlue;
            this.wiseButton4.SubTextFont = new System.Drawing.Font("Arial", 9F);
            this.wiseButton4.TabIndex = 5;
            this.wiseButton4.Text = "wiseButton4";
            this.wiseButton4.UseVisualStyleBackColor = true;
            // 
            // wiseButton3
            // 
            wiseCorner14.All = -1;
            wiseCorner14.BottomLeft = 15;
            wiseCorner14.BottomRight = 0;
            wiseCorner14.TopLeft = 15;
            wiseCorner14.TopRight = 0;
            this.wiseButton3.CornerRadius = wiseCorner14;
            this.wiseButton3.Location = new System.Drawing.Point(12, 48);
            this.wiseButton3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.wiseButton3.Name = "wiseButton3";
            this.wiseButton3.Size = new System.Drawing.Size(32, 47);
            this.wiseButton3.SolidColorDown = System.Drawing.Color.LightBlue;
            this.wiseButton3.SolidColorHover = System.Drawing.Color.LightBlue;
            this.wiseButton3.SolidColorNormal = System.Drawing.Color.LightBlue;
            this.wiseButton3.SubTextFont = new System.Drawing.Font("Arial", 9F);
            this.wiseButton3.TabIndex = 4;
            this.wiseButton3.Text = "wiseButton3";
            this.wiseButton3.UseVisualStyleBackColor = true;
            // 
            // wiseButton2
            // 
            wiseCorner15.All = 0;
            wiseCorner15.BottomLeft = 0;
            wiseCorner15.BottomRight = 0;
            wiseCorner15.TopLeft = 0;
            wiseCorner15.TopRight = 0;
            this.wiseButton2.CornerRadius = wiseCorner15;
            this.wiseButton2.Location = new System.Drawing.Point(139, 74);
            this.wiseButton2.Name = "wiseButton2";
            this.wiseButton2.Size = new System.Drawing.Size(75, 23);
            this.wiseButton2.SolidColorDown = System.Drawing.Color.LightBlue;
            this.wiseButton2.SolidColorHover = System.Drawing.Color.LightBlue;
            this.wiseButton2.SolidColorNormal = System.Drawing.Color.LightBlue;
            this.wiseButton2.SubTextFont = new System.Drawing.Font("Arial", 9F);
            this.wiseButton2.TabIndex = 3;
            this.wiseButton2.Text = "&PlayMIDI";
            this.wiseButton2.UseVisualStyleBackColor = true;
            this.wiseButton2.Click += new System.EventHandler(this.wiseButton2_Click);
            // 
            // wiseProgressBar2
            // 
            this.wiseProgressBar2.Animated = true;
            this.wiseProgressBar2.Location = new System.Drawing.Point(12, 12);
            this.wiseProgressBar2.Name = "wiseProgressBar2";
            this.wiseProgressBar2.Size = new System.Drawing.Size(201, 10);
            this.wiseProgressBar2.TabIndex = 2;
            this.wiseProgressBar2.Value = 50;
            // 
            // wiseProgressBar1
            // 
            this.wiseProgressBar1.Location = new System.Drawing.Point(12, 28);
            this.wiseProgressBar1.Name = "wiseProgressBar1";
            this.wiseProgressBar1.Size = new System.Drawing.Size(201, 10);
            this.wiseProgressBar1.TabIndex = 1;
            this.wiseProgressBar1.Value = 50;
            // 
            // wiseButton1
            // 
            wiseCorner16.All = 0;
            wiseCorner16.BottomLeft = 0;
            wiseCorner16.BottomRight = 0;
            wiseCorner16.TopLeft = 0;
            wiseCorner16.TopRight = 0;
            this.wiseButton1.CornerRadius = wiseCorner16;
            this.wiseButton1.Location = new System.Drawing.Point(139, 45);
            this.wiseButton1.Name = "wiseButton1";
            this.wiseButton1.Size = new System.Drawing.Size(75, 23);
            this.wiseButton1.SolidColorDown = System.Drawing.Color.LightBlue;
            this.wiseButton1.SolidColorHover = System.Drawing.Color.LightBlue;
            this.wiseButton1.SolidColorNormal = System.Drawing.Color.LightBlue;
            this.wiseButton1.SubTextFont = new System.Drawing.Font("Arial", 9F);
            this.wiseButton1.TabIndex = 0;
            this.wiseButton1.Text = "&OpenDialog";
            this.wiseButton1.UseVisualStyleBackColor = true;
            this.wiseButton1.Click += new System.EventHandler(this.wiseButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 352);
            this.Controls.Add(this.wiseListBox1);
            this.Controls.Add(this.wiseProgressBar3);
            this.Controls.Add(this.wiseCheckBox1);
            this.Controls.Add(this.wiseListView1);
            this.Controls.Add(this.wiseTreeView1);
            this.Controls.Add(this.wiseButton4);
            this.Controls.Add(this.wiseButton3);
            this.Controls.Add(this.wiseButton2);
            this.Controls.Add(this.wiseProgressBar2);
            this.Controls.Add(this.wiseProgressBar1);
            this.Controls.Add(this.wiseButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WiseClockie.Forms.WiseButton wiseButton1;
        private WiseClockie.Forms.WiseProgressBar wiseProgressBar1;
        private WiseClockie.Forms.WiseProgressBar wiseProgressBar2;
        private WiseClockie.Forms.WiseButton wiseButton2;
        private WiseClockie.Forms.WiseButton wiseButton3;
        private WiseClockie.Forms.WiseButton wiseButton4;
        private WiseClockie.Forms.WiseTreeView wiseTreeView1;
        private WiseClockie.Forms.WiseListView wiseListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private WiseClockie.Forms.WiseCheckBox wiseCheckBox1;
        private WiseClockie.Forms.WiseProgressBar wiseProgressBar3;
        private WiseClockie.Forms.WiseListBox wiseListBox1;
    }
}


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
            WiseCorner wiseCorner1 = new WiseCorner();
            WiseCorner wiseCorner2 = new WiseCorner();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Action", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("FPS", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "21",
            "22"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node8", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            WiseCorner wiseCorner3 = new WiseCorner();
            WiseCorner wiseCorner4 = new WiseCorner();
            WiseCorner wiseCorner5 = new WiseCorner();
            WiseCorner wiseCorner6 = new WiseCorner();
            this.wiseButton6 = new WiseClockie.Forms.WiseButton();
            this.wiseCheckBox1 = new WiseClockie.Forms.WiseCheckBox();
            this.wiseButton5 = new WiseClockie.Forms.WiseButton();
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
            // wiseButton6
            // 
            this.wiseButton6.BorderColor = System.Drawing.Color.Red;
            this.wiseButton6.BorderSize = 3;
            wiseCorner1.All = 0;
            wiseCorner1.BottomLeft = 0;
            wiseCorner1.BottomRight = 0;
            wiseCorner1.TopLeft = 0;
            wiseCorner1.TopRight = 0;
            this.wiseButton6.CornerRadius = wiseCorner1;
            this.wiseButton6.DrawBorder = true;
            this.wiseButton6.GradientColorDown1 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton6.GradientColorDown2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton6.GradientColorHover1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.wiseButton6.GradientColorHover2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.wiseButton6.GradientColorNormal1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton6.GradientColorNormal2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton6.IsGradient = false;
            this.wiseButton6.Location = new System.Drawing.Point(95, 201);
            this.wiseButton6.Name = "wiseButton6";
            this.wiseButton6.Size = new System.Drawing.Size(75, 23);
            this.wiseButton6.SolidColorDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton6.SolidColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.wiseButton6.SolidColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton6.SubTextColor = System.Drawing.Color.Gray;
            this.wiseButton6.SubTextFont = new System.Drawing.Font("Arial", 9F);
            this.wiseButton6.TabIndex = 10;
            this.wiseButton6.Text = "wiseButton6";
            this.wiseButton6.UseVisualStyleBackColor = true;
            // 
            // wiseCheckBox1
            // 
            this.wiseCheckBox1.AutoSize = true;
            this.wiseCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wiseCheckBox1.Location = new System.Drawing.Point(95, 176);
            this.wiseCheckBox1.Name = "wiseCheckBox1";
            this.wiseCheckBox1.Size = new System.Drawing.Size(113, 19);
            this.wiseCheckBox1.TabIndex = 9;
            this.wiseCheckBox1.Text = "wiseCheckBox1";
            this.wiseCheckBox1.UseVisualStyleBackColor = true;
            // 
            // wiseButton5
            // 
            this.wiseButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.wiseButton5.BorderSize = 1;
            wiseCorner2.All = 0;
            wiseCorner2.BottomLeft = 0;
            wiseCorner2.BottomRight = 0;
            wiseCorner2.TopLeft = 0;
            wiseCorner2.TopRight = 0;
            this.wiseButton5.CornerRadius = wiseCorner2;
            this.wiseButton5.DrawBorder = true;
            this.wiseButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wiseButton5.GradientColorDown1 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton5.GradientColorDown2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton5.GradientColorHover1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.wiseButton5.GradientColorHover2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.wiseButton5.GradientColorNormal1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton5.GradientColorNormal2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton5.IsGradient = false;
            this.wiseButton5.Location = new System.Drawing.Point(95, 103);
            this.wiseButton5.Name = "wiseButton5";
            this.wiseButton5.Size = new System.Drawing.Size(119, 67);
            this.wiseButton5.SolidColorDown = System.Drawing.Color.DarkBlue;
            this.wiseButton5.SolidColorHover = System.Drawing.Color.MediumBlue;
            this.wiseButton5.SolidColorNormal = System.Drawing.Color.LightBlue;
            this.wiseButton5.SubText = "Test";
            this.wiseButton5.SubTextColor = System.Drawing.Color.Gray;
            this.wiseButton5.SubTextFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wiseButton5.TabIndex = 8;
            this.wiseButton5.Text = "wiseButton5";
            this.wiseButton5.UseVisualStyleBackColor = true;
            // 
            // wiseListView1
            // 
            this.wiseListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.wiseListView1.FullRowSelect = true;
            listViewGroup1.Header = "Action";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "FPS";
            listViewGroup2.Name = "listViewGroup2";
            this.wiseListView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            this.wiseListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.wiseListView1.Location = new System.Drawing.Point(219, 12);
            this.wiseListView1.Name = "wiseListView1";
            this.wiseListView1.Size = new System.Drawing.Size(170, 238);
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
            this.wiseTreeView1.Location = new System.Drawing.Point(12, 101);
            this.wiseTreeView1.Name = "wiseTreeView1";
            treeNode1.Name = "Node7";
            treeNode1.Text = "Node7";
            treeNode2.Name = "Node10";
            treeNode2.Text = "Node10";
            treeNode3.Name = "Node8";
            treeNode3.Text = "Node8";
            treeNode4.Name = "Node9";
            treeNode4.Text = "Node9";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Node0";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Node3";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Node4";
            treeNode8.Name = "Node5";
            treeNode8.Text = "Node5";
            treeNode9.Name = "Node6";
            treeNode9.Text = "Node6";
            treeNode10.Name = "Node2";
            treeNode10.Text = "Node2";
            treeNode11.Name = "Node1";
            treeNode11.Text = "Node1";
            this.wiseTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode11});
            this.wiseTreeView1.Size = new System.Drawing.Size(77, 149);
            this.wiseTreeView1.TabIndex = 6;
            // 
            // wiseButton4
            // 
            this.wiseButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.wiseButton4.BorderSize = 3;
            wiseCorner3.All = -1;
            wiseCorner3.BottomLeft = 0;
            wiseCorner3.BottomRight = 15;
            wiseCorner3.TopLeft = 0;
            wiseCorner3.TopRight = 15;
            this.wiseButton4.CornerRadius = wiseCorner3;
            this.wiseButton4.DrawBorder = true;
            this.wiseButton4.GradientColorDown1 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton4.GradientColorDown2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton4.GradientColorHover1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.wiseButton4.GradientColorHover2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.wiseButton4.GradientColorNormal1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton4.GradientColorNormal2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton4.IsGradient = true;
            this.wiseButton4.Location = new System.Drawing.Point(43, 48);
            this.wiseButton4.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.wiseButton4.Name = "wiseButton4";
            this.wiseButton4.Size = new System.Drawing.Size(90, 47);
            this.wiseButton4.SolidColorDown = System.Drawing.Color.LightBlue;
            this.wiseButton4.SolidColorHover = System.Drawing.Color.LightBlue;
            this.wiseButton4.SolidColorNormal = System.Drawing.Color.LightBlue;
            this.wiseButton4.SubTextColor = System.Drawing.Color.Gray;
            this.wiseButton4.SubTextFont = new System.Drawing.Font("Arial", 9F);
            this.wiseButton4.TabIndex = 5;
            this.wiseButton4.Text = "wiseButton4";
            this.wiseButton4.UseVisualStyleBackColor = true;
            // 
            // wiseButton3
            // 
            this.wiseButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.wiseButton3.BorderSize = 1;
            wiseCorner4.All = -1;
            wiseCorner4.BottomLeft = 15;
            wiseCorner4.BottomRight = 0;
            wiseCorner4.TopLeft = 15;
            wiseCorner4.TopRight = 0;
            this.wiseButton3.CornerRadius = wiseCorner4;
            this.wiseButton3.DrawBorder = true;
            this.wiseButton3.GradientColorDown1 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton3.GradientColorDown2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton3.GradientColorHover1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.wiseButton3.GradientColorHover2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.wiseButton3.GradientColorNormal1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton3.GradientColorNormal2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton3.IsGradient = true;
            this.wiseButton3.Location = new System.Drawing.Point(12, 48);
            this.wiseButton3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.wiseButton3.Name = "wiseButton3";
            this.wiseButton3.Size = new System.Drawing.Size(32, 47);
            this.wiseButton3.SolidColorDown = System.Drawing.Color.LightBlue;
            this.wiseButton3.SolidColorHover = System.Drawing.Color.LightBlue;
            this.wiseButton3.SolidColorNormal = System.Drawing.Color.LightBlue;
            this.wiseButton3.SubTextColor = System.Drawing.Color.Gray;
            this.wiseButton3.SubTextFont = new System.Drawing.Font("Arial", 9F);
            this.wiseButton3.TabIndex = 4;
            this.wiseButton3.Text = "wiseButton3";
            this.wiseButton3.UseVisualStyleBackColor = true;
            // 
            // wiseButton2
            // 
            this.wiseButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.wiseButton2.BorderSize = 1;
            wiseCorner5.All = 0;
            wiseCorner5.BottomLeft = 0;
            wiseCorner5.BottomRight = 0;
            wiseCorner5.TopLeft = 0;
            wiseCorner5.TopRight = 0;
            this.wiseButton2.CornerRadius = wiseCorner5;
            this.wiseButton2.DrawBorder = true;
            this.wiseButton2.GradientColorDown1 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton2.GradientColorDown2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton2.GradientColorHover1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.wiseButton2.GradientColorHover2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.wiseButton2.GradientColorNormal1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton2.GradientColorNormal2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton2.IsGradient = true;
            this.wiseButton2.Location = new System.Drawing.Point(139, 74);
            this.wiseButton2.Name = "wiseButton2";
            this.wiseButton2.Size = new System.Drawing.Size(75, 23);
            this.wiseButton2.SolidColorDown = System.Drawing.Color.LightBlue;
            this.wiseButton2.SolidColorHover = System.Drawing.Color.LightBlue;
            this.wiseButton2.SolidColorNormal = System.Drawing.Color.LightBlue;
            this.wiseButton2.SubTextColor = System.Drawing.Color.Gray;
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
            this.wiseButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.wiseButton1.BorderSize = 1;
            wiseCorner6.All = 0;
            wiseCorner6.BottomLeft = 0;
            wiseCorner6.BottomRight = 0;
            wiseCorner6.TopLeft = 0;
            wiseCorner6.TopRight = 0;
            this.wiseButton1.CornerRadius = wiseCorner6;
            this.wiseButton1.DrawBorder = true;
            this.wiseButton1.GradientColorDown1 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton1.GradientColorDown2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton1.GradientColorHover1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.wiseButton1.GradientColorHover2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(196)))), ((int)(((byte)(203)))));
            this.wiseButton1.GradientColorNormal1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.wiseButton1.GradientColorNormal2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.wiseButton1.IsGradient = true;
            this.wiseButton1.Location = new System.Drawing.Point(139, 45);
            this.wiseButton1.Name = "wiseButton1";
            this.wiseButton1.Size = new System.Drawing.Size(75, 23);
            this.wiseButton1.SolidColorDown = System.Drawing.Color.LightBlue;
            this.wiseButton1.SolidColorHover = System.Drawing.Color.LightBlue;
            this.wiseButton1.SolidColorNormal = System.Drawing.Color.LightBlue;
            this.wiseButton1.SubTextColor = System.Drawing.Color.Gray;
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
            this.ClientSize = new System.Drawing.Size(401, 262);
            this.Controls.Add(this.wiseButton6);
            this.Controls.Add(this.wiseCheckBox1);
            this.Controls.Add(this.wiseButton5);
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
        private WiseClockie.Forms.WiseButton wiseButton5;
        private WiseClockie.Forms.WiseCheckBox wiseCheckBox1;
        private WiseClockie.Forms.WiseButton wiseButton6;
    }
}


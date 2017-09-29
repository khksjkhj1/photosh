namespace ss3project
{
    partial class prototype
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveasButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBoxIpl2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.간단필터ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그레이ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선명히ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.부드럽게ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.엠보싱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.세피아ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.아쿠아ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.밝기변환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고급필터ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이진화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.캐니엣지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.소벨엣지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.라플라스엣지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색상검출ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.기타ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사이즈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.얼굴검출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그림판ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그림판ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.saveasButton);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 532);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(573, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // saveasButton
            // 
            this.saveasButton.Location = new System.Drawing.Point(387, 25);
            this.saveasButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveasButton.Name = "saveasButton";
            this.saveasButton.Size = new System.Drawing.Size(178, 108);
            this.saveasButton.TabIndex = 2;
            this.saveasButton.Text = "Save As";
            this.saveasButton.UseVisualStyleBackColor = true;
            this.saveasButton.Click += new System.EventHandler(this.saveasButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(194, 25);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(186, 108);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(7, 25);
            this.openButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(181, 108);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxIpl1.Location = new System.Drawing.Point(0, 40);
            this.pictureBoxIpl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(519, 456);
            this.pictureBoxIpl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl1.TabIndex = 9;
            this.pictureBoxIpl1.TabStop = false;
            this.pictureBoxIpl1.Click += new System.EventHandler(this.pictureBoxIpl1_Click_1);
            // 
            // pictureBoxIpl2
            // 
            this.pictureBoxIpl2.Location = new System.Drawing.Point(526, 40);
            this.pictureBoxIpl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxIpl2.Name = "pictureBoxIpl2";
            this.pictureBoxIpl2.Size = new System.Drawing.Size(522, 456);
            this.pictureBoxIpl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIpl2.TabIndex = 10;
            this.pictureBoxIpl2.TabStop = false;
            this.pictureBoxIpl2.Click += new System.EventHandler(this.pictureBoxIpl2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.간단필터ToolStripMenuItem,
            this.고급필터ToolStripMenuItem,
            this.기타ToolStripMenuItem,
            this.그림판ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1048, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 간단필터ToolStripMenuItem
            // 
            this.간단필터ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그레이ToolStripMenuItem,
            this.선명히ToolStripMenuItem,
            this.부드럽게ToolStripMenuItem,
            this.엠보싱ToolStripMenuItem,
            this.세피아ToolStripMenuItem,
            this.아쿠아ToolStripMenuItem,
            this.밝기변환ToolStripMenuItem});
            this.간단필터ToolStripMenuItem.Name = "간단필터ToolStripMenuItem";
            this.간단필터ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.간단필터ToolStripMenuItem.Text = "간단필터";
            // 
            // 그레이ToolStripMenuItem
            // 
            this.그레이ToolStripMenuItem.Name = "그레이ToolStripMenuItem";
            this.그레이ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.그레이ToolStripMenuItem.Text = "그레이";
            this.그레이ToolStripMenuItem.Click += new System.EventHandler(this.그레이ToolStripMenuItem_Click);
            // 
            // 선명히ToolStripMenuItem
            // 
            this.선명히ToolStripMenuItem.Name = "선명히ToolStripMenuItem";
            this.선명히ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.선명히ToolStripMenuItem.Text = "선명히";
            this.선명히ToolStripMenuItem.Click += new System.EventHandler(this.선명히ToolStripMenuItem_Click);
            // 
            // 부드럽게ToolStripMenuItem
            // 
            this.부드럽게ToolStripMenuItem.Name = "부드럽게ToolStripMenuItem";
            this.부드럽게ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.부드럽게ToolStripMenuItem.Text = "부드럽게";
            this.부드럽게ToolStripMenuItem.Click += new System.EventHandler(this.부드럽게ToolStripMenuItem_Click);
            // 
            // 엠보싱ToolStripMenuItem
            // 
            this.엠보싱ToolStripMenuItem.Name = "엠보싱ToolStripMenuItem";
            this.엠보싱ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.엠보싱ToolStripMenuItem.Text = "엠보싱";
            this.엠보싱ToolStripMenuItem.Click += new System.EventHandler(this.엠보싱ToolStripMenuItem_Click);
            // 
            // 세피아ToolStripMenuItem
            // 
            this.세피아ToolStripMenuItem.Name = "세피아ToolStripMenuItem";
            this.세피아ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.세피아ToolStripMenuItem.Text = "세피아";
            this.세피아ToolStripMenuItem.Click += new System.EventHandler(this.세피아ToolStripMenuItem_Click);
            // 
            // 아쿠아ToolStripMenuItem
            // 
            this.아쿠아ToolStripMenuItem.Name = "아쿠아ToolStripMenuItem";
            this.아쿠아ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.아쿠아ToolStripMenuItem.Text = "아쿠아";
            this.아쿠아ToolStripMenuItem.Click += new System.EventHandler(this.아쿠아ToolStripMenuItem_Click);
            // 
            // 밝기변환ToolStripMenuItem
            // 
            this.밝기변환ToolStripMenuItem.Name = "밝기변환ToolStripMenuItem";
            this.밝기변환ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.밝기변환ToolStripMenuItem.Text = "밝기변환";
            this.밝기변환ToolStripMenuItem.Click += new System.EventHandler(this.밝기변환ToolStripMenuItem_Click);
            // 
            // 고급필터ToolStripMenuItem
            // 
            this.고급필터ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이진화ToolStripMenuItem,
            this.캐니엣지ToolStripMenuItem,
            this.소벨엣지ToolStripMenuItem,
            this.라플라스엣지ToolStripMenuItem,
            this.색상검출ToolStripMenuItem1});
            this.고급필터ToolStripMenuItem.Name = "고급필터ToolStripMenuItem";
            this.고급필터ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.고급필터ToolStripMenuItem.Text = "고급필터";
            // 
            // 이진화ToolStripMenuItem
            // 
            this.이진화ToolStripMenuItem.Name = "이진화ToolStripMenuItem";
            this.이진화ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.이진화ToolStripMenuItem.Text = "이진화";
            this.이진화ToolStripMenuItem.Click += new System.EventHandler(this.이진화ToolStripMenuItem_Click);
            // 
            // 캐니엣지ToolStripMenuItem
            // 
            this.캐니엣지ToolStripMenuItem.Name = "캐니엣지ToolStripMenuItem";
            this.캐니엣지ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.캐니엣지ToolStripMenuItem.Text = "캐니엣지";
            this.캐니엣지ToolStripMenuItem.Click += new System.EventHandler(this.캐니엣지ToolStripMenuItem_Click);
            // 
            // 소벨엣지ToolStripMenuItem
            // 
            this.소벨엣지ToolStripMenuItem.Name = "소벨엣지ToolStripMenuItem";
            this.소벨엣지ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.소벨엣지ToolStripMenuItem.Text = "소벨엣지";
            this.소벨엣지ToolStripMenuItem.Click += new System.EventHandler(this.소벨엣지ToolStripMenuItem_Click);
            // 
            // 라플라스엣지ToolStripMenuItem
            // 
            this.라플라스엣지ToolStripMenuItem.Name = "라플라스엣지ToolStripMenuItem";
            this.라플라스엣지ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.라플라스엣지ToolStripMenuItem.Text = "라플라스엣지";
            this.라플라스엣지ToolStripMenuItem.Click += new System.EventHandler(this.라플라스엣지ToolStripMenuItem_Click);
            // 
            // 색상검출ToolStripMenuItem1
            // 
            this.색상검출ToolStripMenuItem1.Name = "색상검출ToolStripMenuItem1";
            this.색상검출ToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.색상검출ToolStripMenuItem1.Text = "색상검출";
            this.색상검출ToolStripMenuItem1.Click += new System.EventHandler(this.색상검출ToolStripMenuItem1_Click);
            // 
            // 기타ToolStripMenuItem
            // 
            this.기타ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회전ToolStripMenuItem,
            this.사이즈ToolStripMenuItem,
            this.얼굴검출ToolStripMenuItem});
            this.기타ToolStripMenuItem.Name = "기타ToolStripMenuItem";
            this.기타ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.기타ToolStripMenuItem.Text = "기타";
            // 
            // 회전ToolStripMenuItem
            // 
            this.회전ToolStripMenuItem.Name = "회전ToolStripMenuItem";
            this.회전ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.회전ToolStripMenuItem.Text = "회전";
            this.회전ToolStripMenuItem.Click += new System.EventHandler(this.회전ToolStripMenuItem_Click);
            // 
            // 사이즈ToolStripMenuItem
            // 
            this.사이즈ToolStripMenuItem.Name = "사이즈ToolStripMenuItem";
            this.사이즈ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.사이즈ToolStripMenuItem.Text = "사이즈";
            this.사이즈ToolStripMenuItem.Click += new System.EventHandler(this.사이즈ToolStripMenuItem_Click);
            // 
            // 얼굴검출ToolStripMenuItem
            // 
            this.얼굴검출ToolStripMenuItem.Name = "얼굴검출ToolStripMenuItem";
            this.얼굴검출ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.얼굴검출ToolStripMenuItem.Text = "얼굴검출";
            this.얼굴검출ToolStripMenuItem.Click += new System.EventHandler(this.얼굴검출ToolStripMenuItem_Click);
            // 
            // 그림판ToolStripMenuItem
            // 
            this.그림판ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그림판ToolStripMenuItem1});
            this.그림판ToolStripMenuItem.Name = "그림판ToolStripMenuItem";
            this.그림판ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.그림판ToolStripMenuItem.Text = "그림판";
            // 
            // 그림판ToolStripMenuItem1
            // 
            this.그림판ToolStripMenuItem1.Name = "그림판ToolStripMenuItem1";
            this.그림판ToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.그림판ToolStripMenuItem1.Text = "그림판";
            this.그림판ToolStripMenuItem1.Click += new System.EventHandler(this.그림판ToolStripMenuItem1_Click);
            // 
            // prototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 685);
            this.Controls.Add(this.pictureBoxIpl2);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "prototype";
            this.Text = "prototype";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveasButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 간단필터ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그레이ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고급필터ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기타ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회전ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사이즈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이진화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 캐니엣지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 소벨엣지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 라플라스엣지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선명히ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 부드럽게ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 엠보싱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 세피아ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 아쿠아ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 얼굴검출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 밝기변환ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상검출ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 그림판ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그림판ToolStripMenuItem1;
    }
}


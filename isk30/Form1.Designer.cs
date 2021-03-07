
namespace isk30
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
            this.pont1update = new System.Windows.Forms.Button();
            this.pont2update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.TavlosagBtn = new System.Windows.Forms.Button();
            this.pont1y = new System.Windows.Forms.TextBox();
            this.pont2x = new System.Windows.Forms.TextBox();
            this.pont1x = new System.Windows.Forms.TextBox();
            this.pont2y = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xMove = new System.Windows.Forms.TextBox();
            this.yMove = new System.Windows.Forms.TextBox();
            this.MoveBtn = new System.Windows.Forms.Button();
            this.pontToMove = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pont1update
            // 
            this.pont1update.Location = new System.Drawing.Point(230, 48);
            this.pont1update.Name = "pont1update";
            this.pont1update.Size = new System.Drawing.Size(75, 23);
            this.pont1update.TabIndex = 0;
            this.pont1update.Text = "Update";
            this.pont1update.UseVisualStyleBackColor = true;
            this.pont1update.Click += new System.EventHandler(this.pont1update_Click);
            // 
            // pont2update
            // 
            this.pont2update.Location = new System.Drawing.Point(230, 78);
            this.pont2update.Name = "pont2update";
            this.pont2update.Size = new System.Drawing.Size(75, 23);
            this.pont2update.TabIndex = 1;
            this.pont2update.Text = "Update";
            this.pont2update.UseVisualStyleBackColor = true;
            this.pont2update.Click += new System.EventHandler(this.pont2update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(196, 199);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(20, 24);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "0";
            // 
            // TavlosagBtn
            // 
            this.TavlosagBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TavlosagBtn.Location = new System.Drawing.Point(31, 202);
            this.TavlosagBtn.Name = "TavlosagBtn";
            this.TavlosagBtn.Size = new System.Drawing.Size(75, 23);
            this.TavlosagBtn.TabIndex = 8;
            this.TavlosagBtn.Text = "Tavolsag";
            this.TavlosagBtn.UseVisualStyleBackColor = true;
            this.TavlosagBtn.Click += new System.EventHandler(this.TavlosagBtn_Click);
            // 
            // pont1y
            // 
            this.pont1y.Location = new System.Drawing.Point(124, 50);
            this.pont1y.Name = "pont1y";
            this.pont1y.Size = new System.Drawing.Size(100, 20);
            this.pont1y.TabIndex = 9;
            this.pont1y.Text = "0";
            // 
            // pont2x
            // 
            this.pont2x.Location = new System.Drawing.Point(6, 80);
            this.pont2x.Name = "pont2x";
            this.pont2x.Size = new System.Drawing.Size(100, 20);
            this.pont2x.TabIndex = 10;
            this.pont2x.Text = "0";
            // 
            // pont1x
            // 
            this.pont1x.Location = new System.Drawing.Point(6, 50);
            this.pont1x.Name = "pont1x";
            this.pont1x.Size = new System.Drawing.Size(100, 20);
            this.pont1x.TabIndex = 11;
            this.pont1x.Text = "0";
            // 
            // pont2y
            // 
            this.pont2y.Location = new System.Drawing.Point(124, 80);
            this.pont2y.Name = "pont2y";
            this.pont2y.Size = new System.Drawing.Size(100, 20);
            this.pont2y.TabIndex = 12;
            this.pont2y.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pont2x);
            this.groupBox1.Controls.Add(this.pont2y);
            this.groupBox1.Controls.Add(this.pont1update);
            this.groupBox1.Controls.Add(this.pont1x);
            this.groupBox1.Controls.Add(this.pont2update);
            this.groupBox1.Controls.Add(this.pont1y);
            this.groupBox1.Location = new System.Drawing.Point(31, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 147);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Updating points";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pontToMove);
            this.groupBox2.Controls.Add(this.MoveBtn);
            this.groupBox2.Controls.Add(this.yMove);
            this.groupBox2.Controls.Add(this.xMove);
            this.groupBox2.Location = new System.Drawing.Point(349, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 147);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Move points";
            // 
            // xMove
            // 
            this.xMove.Location = new System.Drawing.Point(7, 48);
            this.xMove.Name = "xMove";
            this.xMove.Size = new System.Drawing.Size(100, 20);
            this.xMove.TabIndex = 0;
            // 
            // yMove
            // 
            this.yMove.Location = new System.Drawing.Point(7, 79);
            this.yMove.Name = "yMove";
            this.yMove.Size = new System.Drawing.Size(100, 20);
            this.yMove.TabIndex = 1;
            // 
            // MoveBtn
            // 
            this.MoveBtn.Location = new System.Drawing.Point(113, 48);
            this.MoveBtn.Name = "MoveBtn";
            this.MoveBtn.Size = new System.Drawing.Size(75, 23);
            this.MoveBtn.TabIndex = 2;
            this.MoveBtn.Text = "Move";
            this.MoveBtn.UseVisualStyleBackColor = true;
            this.MoveBtn.Click += new System.EventHandler(this.MoveBtn_Click);
            // 
            // pontToMove
            // 
            this.pontToMove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pontToMove.FormattingEnabled = true;
            this.pontToMove.Items.AddRange(new object[] {
            "Pont 1",
            "Pont 2"});
            this.pontToMove.Location = new System.Drawing.Point(113, 80);
            this.pontToMove.Name = "pontToMove";
            this.pontToMove.Size = new System.Drawing.Size(75, 21);
            this.pontToMove.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 239);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TavlosagBtn);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pont1update;
        private System.Windows.Forms.Button pont2update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button TavlosagBtn;
        private System.Windows.Forms.TextBox pont1y;
        private System.Windows.Forms.TextBox pont2x;
        private System.Windows.Forms.TextBox pont1x;
        private System.Windows.Forms.TextBox pont2y;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MoveBtn;
        private System.Windows.Forms.TextBox yMove;
        private System.Windows.Forms.TextBox xMove;
        private System.Windows.Forms.ComboBox pontToMove;
    }
}


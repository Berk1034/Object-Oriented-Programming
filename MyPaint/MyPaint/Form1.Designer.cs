﻿namespace MyPaint
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Canvas = new System.Windows.Forms.Panel();
            this.btnLine = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.pnlCommon = new System.Windows.Forms.Panel();
            this.btnChangePenColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tBarWidth = new System.Windows.Forms.TrackBar();
            this.lblPenWidth = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.pnlCommon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(101, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(881, 853);
            this.Canvas.TabIndex = 1;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(0, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(101, 60);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlButtons.Controls.Add(this.lblPenWidth);
            this.pnlButtons.Controls.Add(this.tBarWidth);
            this.pnlButtons.Controls.Add(this.btnChangePenColor);
            this.pnlButtons.Controls.Add(this.btnCircle);
            this.pnlButtons.Controls.Add(this.btnSquare);
            this.pnlButtons.Controls.Add(this.btnEllipse);
            this.pnlButtons.Controls.Add(this.btnRectangle);
            this.pnlButtons.Controls.Add(this.btnLine);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(101, 853);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(0, 276);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(101, 60);
            this.btnCircle.TabIndex = 4;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(0, 210);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(101, 60);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(0, 144);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(101, 60);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(0, 78);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(101, 60);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // pnlCommon
            // 
            this.pnlCommon.Controls.Add(this.Canvas);
            this.pnlCommon.Controls.Add(this.pnlButtons);
            this.pnlCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommon.Location = new System.Drawing.Point(0, 0);
            this.pnlCommon.Name = "pnlCommon";
            this.pnlCommon.Size = new System.Drawing.Size(982, 853);
            this.pnlCommon.TabIndex = 0;
            // 
            // btnChangePenColor
            // 
            this.btnChangePenColor.Location = new System.Drawing.Point(0, 781);
            this.btnChangePenColor.Name = "btnChangePenColor";
            this.btnChangePenColor.Size = new System.Drawing.Size(101, 60);
            this.btnChangePenColor.TabIndex = 6;
            this.btnChangePenColor.Text = "Change Pen Color";
            this.btnChangePenColor.UseVisualStyleBackColor = true;
            this.btnChangePenColor.Click += new System.EventHandler(this.btnChangePenColor_Click);
            // 
            // tBarWidth
            // 
            this.tBarWidth.Location = new System.Drawing.Point(3, 719);
            this.tBarWidth.Name = "tBarWidth";
            this.tBarWidth.Size = new System.Drawing.Size(95, 56);
            this.tBarWidth.TabIndex = 7;
            this.tBarWidth.Scroll += new System.EventHandler(this.tBarWidth_Scroll);
            // 
            // lblPenWidth
            // 
            this.lblPenWidth.AutoSize = true;
            this.lblPenWidth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPenWidth.Location = new System.Drawing.Point(3, 699);
            this.lblPenWidth.Name = "lblPenWidth";
            this.lblPenWidth.Size = new System.Drawing.Size(97, 17);
            this.lblPenWidth.TabIndex = 8;
            this.lblPenWidth.Text = "Change Width";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 853);
            this.Controls.Add(this.pnlCommon);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "TheBestPaintEver";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlCommon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tBarWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlCommon;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnChangePenColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lblPenWidth;
        private System.Windows.Forms.TrackBar tBarWidth;
    }
}


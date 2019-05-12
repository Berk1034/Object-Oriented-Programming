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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.ShapePictureBox = new System.Windows.Forms.PictureBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlShapes = new System.Windows.Forms.Panel();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnPlugin = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPenWidth = new System.Windows.Forms.Label();
            this.tBarWidth = new System.Windows.Forms.TrackBar();
            this.btnChangePenColor = new System.Windows.Forms.Button();
            this.pnlCommon = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pnlPlugins = new System.Windows.Forms.Panel();
            this.pnlCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShapePictureBox)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlShapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarWidth)).BeginInit();
            this.pnlCommon.SuspendLayout();
            this.pnlPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlCanvas.Controls.Add(this.ShapePictureBox);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(101, 0);
            this.pnlCanvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1140, 860);
            this.pnlCanvas.TabIndex = 1;
            // 
            // ShapePictureBox
            // 
            this.ShapePictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.ShapePictureBox.Location = new System.Drawing.Point(0, 0);
            this.ShapePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShapePictureBox.Name = "ShapePictureBox";
            this.ShapePictureBox.Size = new System.Drawing.Size(1141, 866);
            this.ShapePictureBox.TabIndex = 0;
            this.ShapePictureBox.TabStop = false;
            this.ShapePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ShapePictureBox_Paint);
            this.ShapePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShapePictureBox_MouseDown);
            this.ShapePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShapePictureBox_MouseMove);
            this.ShapePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShapePictureBox_MouseUp);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(0, 4);
            this.btnLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(101, 40);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlButtons.Controls.Add(this.pnlPlugins);
            this.pnlButtons.Controls.Add(this.pnlShapes);
            this.pnlButtons.Controls.Add(this.btnDeserialize);
            this.pnlButtons.Controls.Add(this.btnSerialize);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.lblPenWidth);
            this.pnlButtons.Controls.Add(this.tBarWidth);
            this.pnlButtons.Controls.Add(this.btnChangePenColor);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(101, 860);
            this.pnlButtons.TabIndex = 0;
            // 
            // pnlShapes
            // 
            this.pnlShapes.Controls.Add(this.btnLine);
            this.pnlShapes.Controls.Add(this.btnRectangle);
            this.pnlShapes.Controls.Add(this.btnEllipse);
            this.pnlShapes.Controls.Add(this.btnTriangle);
            this.pnlShapes.Controls.Add(this.btnSquare);
            this.pnlShapes.Controls.Add(this.btnCircle);
            this.pnlShapes.Location = new System.Drawing.Point(0, 0);
            this.pnlShapes.Name = "pnlShapes";
            this.pnlShapes.Size = new System.Drawing.Size(101, 290);
            this.pnlShapes.TabIndex = 1;
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(0, 52);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(101, 40);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(0, 100);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(101, 40);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(0, 244);
            this.btnTriangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(101, 40);
            this.btnTriangle.TabIndex = 10;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(0, 148);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(101, 40);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(0, 196);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(101, 40);
            this.btnCircle.TabIndex = 4;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnPlugin
            // 
            this.btnPlugin.Location = new System.Drawing.Point(0, 0);
            this.btnPlugin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlugin.Name = "btnPlugin";
            this.btnPlugin.Size = new System.Drawing.Size(101, 40);
            this.btnPlugin.TabIndex = 1;
            this.btnPlugin.Text = "Load Plugin";
            this.btnPlugin.UseVisualStyleBackColor = true;
            this.btnPlugin.Click += new System.EventHandler(this.btnPlugin_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(0, 388);
            this.btnDeserialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(101, 40);
            this.btnDeserialize.TabIndex = 12;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(0, 340);
            this.btnSerialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(101, 40);
            this.btnSerialize.TabIndex = 11;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(0, 292);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear ALL";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPenWidth
            // 
            this.lblPenWidth.AutoSize = true;
            this.lblPenWidth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPenWidth.Location = new System.Drawing.Point(3, 737);
            this.lblPenWidth.Name = "lblPenWidth";
            this.lblPenWidth.Size = new System.Drawing.Size(97, 17);
            this.lblPenWidth.TabIndex = 8;
            this.lblPenWidth.Text = "Change Width";
            // 
            // tBarWidth
            // 
            this.tBarWidth.Location = new System.Drawing.Point(3, 758);
            this.tBarWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBarWidth.Name = "tBarWidth";
            this.tBarWidth.Size = new System.Drawing.Size(95, 56);
            this.tBarWidth.TabIndex = 7;
            this.tBarWidth.Scroll += new System.EventHandler(this.tBarWidth_Scroll);
            // 
            // btnChangePenColor
            // 
            this.btnChangePenColor.Location = new System.Drawing.Point(0, 813);
            this.btnChangePenColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePenColor.Name = "btnChangePenColor";
            this.btnChangePenColor.Size = new System.Drawing.Size(101, 43);
            this.btnChangePenColor.TabIndex = 6;
            this.btnChangePenColor.Text = "Change Pen Color";
            this.btnChangePenColor.UseVisualStyleBackColor = true;
            this.btnChangePenColor.Click += new System.EventHandler(this.btnChangePenColor_Click);
            // 
            // pnlCommon
            // 
            this.pnlCommon.Controls.Add(this.pnlCanvas);
            this.pnlCommon.Controls.Add(this.pnlButtons);
            this.pnlCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommon.Location = new System.Drawing.Point(0, 0);
            this.pnlCommon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCommon.Name = "pnlCommon";
            this.pnlCommon.Size = new System.Drawing.Size(1241, 860);
            this.pnlCommon.TabIndex = 0;
            // 
            // pnlPlugins
            // 
            this.pnlPlugins.Controls.Add(this.btnPlugin);
            this.pnlPlugins.Location = new System.Drawing.Point(0, 435);
            this.pnlPlugins.Name = "pnlPlugins";
            this.pnlPlugins.Size = new System.Drawing.Size(101, 299);
            this.pnlPlugins.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 860);
            this.Controls.Add(this.pnlCommon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(739, 345);
            this.Name = "MainForm";
            this.Text = "TheBestPaintEver";
            this.pnlCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShapePictureBox)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlShapes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tBarWidth)).EndInit();
            this.pnlCommon.ResumeLayout(false);
            this.pnlPlugins.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCanvas;
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox ShapePictureBox;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnPlugin;
        private System.Windows.Forms.Panel pnlShapes;
        private System.Windows.Forms.Panel pnlPlugins;
    }
}


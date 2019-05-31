namespace MyPaint
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
            this.lblCustomShape = new System.Windows.Forms.Label();
            this.textBoxCustomShape = new System.Windows.Forms.TextBox();
            this.btnCreateShape = new System.Windows.Forms.Button();
            this.btnChangeBackgroundColor = new System.Windows.Forms.Button();
            this.btnChangePenColor = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.pnlPlugins = new System.Windows.Forms.Panel();
            this.btnPlugin = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.pnlShapes = new System.Windows.Forms.Panel();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPenWidth = new System.Windows.Forms.Label();
            this.tBarWidth = new System.Windows.Forms.TrackBar();
            this.pnlCommon = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.comboBoxCustomShape = new System.Windows.Forms.ComboBox();
            this.btnDeleteShape = new System.Windows.Forms.Button();
            this.btnSaveShape = new System.Windows.Forms.Button();
            this.pnlCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShapePictureBox)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlPlugins.SuspendLayout();
            this.pnlShapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarWidth)).BeginInit();
            this.pnlCommon.SuspendLayout();
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
            this.pnlCanvas.Size = new System.Drawing.Size(1139, 864);
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
            this.btnLine.Size = new System.Drawing.Size(101, 30);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlButtons.Controls.Add(this.btnSaveShape);
            this.pnlButtons.Controls.Add(this.btnDeleteShape);
            this.pnlButtons.Controls.Add(this.comboBoxCustomShape);
            this.pnlButtons.Controls.Add(this.lblCustomShape);
            this.pnlButtons.Controls.Add(this.textBoxCustomShape);
            this.pnlButtons.Controls.Add(this.btnCreateShape);
            this.pnlButtons.Controls.Add(this.btnChangeBackgroundColor);
            this.pnlButtons.Controls.Add(this.btnChangePenColor);
            this.pnlButtons.Controls.Add(this.lblSettings);
            this.pnlButtons.Controls.Add(this.btnLoadSettings);
            this.pnlButtons.Controls.Add(this.pnlPlugins);
            this.pnlButtons.Controls.Add(this.btnSaveSettings);
            this.pnlButtons.Controls.Add(this.pnlShapes);
            this.pnlButtons.Controls.Add(this.btnDeserialize);
            this.pnlButtons.Controls.Add(this.btnSerialize);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.lblPenWidth);
            this.pnlButtons.Controls.Add(this.tBarWidth);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(101, 864);
            this.pnlButtons.TabIndex = 0;
            // 
            // lblCustomShape
            // 
            this.lblCustomShape.AutoSize = true;
            this.lblCustomShape.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCustomShape.Location = new System.Drawing.Point(1, 501);
            this.lblCustomShape.Name = "lblCustomShape";
            this.lblCustomShape.Size = new System.Drawing.Size(100, 17);
            this.lblCustomShape.TabIndex = 16;
            this.lblCustomShape.Text = "Shape\'s Name";
            // 
            // textBoxCustomShape
            // 
            this.textBoxCustomShape.Location = new System.Drawing.Point(1, 521);
            this.textBoxCustomShape.Name = "textBoxCustomShape";
            this.textBoxCustomShape.Size = new System.Drawing.Size(99, 22);
            this.textBoxCustomShape.TabIndex = 15;
            // 
            // btnCreateShape
            // 
            this.btnCreateShape.Location = new System.Drawing.Point(0, 550);
            this.btnCreateShape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateShape.Name = "btnCreateShape";
            this.btnCreateShape.Size = new System.Drawing.Size(101, 26);
            this.btnCreateShape.TabIndex = 12;
            this.btnCreateShape.Text = "Create";
            this.btnCreateShape.UseVisualStyleBackColor = true;
            this.btnCreateShape.Click += new System.EventHandler(this.btnCreateShape_Click);
            // 
            // btnChangeBackgroundColor
            // 
            this.btnChangeBackgroundColor.Location = new System.Drawing.Point(0, 817);
            this.btnChangeBackgroundColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeBackgroundColor.Name = "btnChangeBackgroundColor";
            this.btnChangeBackgroundColor.Size = new System.Drawing.Size(101, 42);
            this.btnChangeBackgroundColor.TabIndex = 7;
            this.btnChangeBackgroundColor.Text = "Background Color";
            this.btnChangeBackgroundColor.UseVisualStyleBackColor = true;
            this.btnChangeBackgroundColor.Click += new System.EventHandler(this.btnChangeBackgroundColor_Click);
            // 
            // btnChangePenColor
            // 
            this.btnChangePenColor.Location = new System.Drawing.Point(0, 788);
            this.btnChangePenColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePenColor.Name = "btnChangePenColor";
            this.btnChangePenColor.Size = new System.Drawing.Size(101, 28);
            this.btnChangePenColor.TabIndex = 6;
            this.btnChangePenColor.Text = "Pen Color";
            this.btnChangePenColor.UseVisualStyleBackColor = true;
            this.btnChangePenColor.Click += new System.EventHandler(this.btnChangePenColor_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSettings.Location = new System.Drawing.Point(23, 690);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(59, 17);
            this.lblSettings.TabIndex = 14;
            this.lblSettings.Text = "Settings";
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(49, 709);
            this.btnLoadSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(52, 23);
            this.btnLoadSettings.TabIndex = 4;
            this.btnLoadSettings.Text = "Load";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // pnlPlugins
            // 
            this.pnlPlugins.Controls.Add(this.btnPlugin);
            this.pnlPlugins.Location = new System.Drawing.Point(0, 357);
            this.pnlPlugins.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPlugins.Name = "pnlPlugins";
            this.pnlPlugins.Size = new System.Drawing.Size(101, 140);
            this.pnlPlugins.TabIndex = 13;
            // 
            // btnPlugin
            // 
            this.btnPlugin.Location = new System.Drawing.Point(0, 0);
            this.btnPlugin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlugin.Name = "btnPlugin";
            this.btnPlugin.Size = new System.Drawing.Size(101, 30);
            this.btnPlugin.TabIndex = 1;
            this.btnPlugin.Text = "Load Plugin";
            this.btnPlugin.UseVisualStyleBackColor = true;
            this.btnPlugin.Click += new System.EventHandler(this.btnPlugin_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(0, 709);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(53, 23);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // pnlShapes
            // 
            this.pnlShapes.Controls.Add(this.btnLine);
            this.pnlShapes.Controls.Add(this.btnTriangle);
            this.pnlShapes.Controls.Add(this.btnRectangle);
            this.pnlShapes.Controls.Add(this.btnSquare);
            this.pnlShapes.Controls.Add(this.btnEllipse);
            this.pnlShapes.Controls.Add(this.btnCircle);
            this.pnlShapes.Location = new System.Drawing.Point(0, 0);
            this.pnlShapes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlShapes.Name = "pnlShapes";
            this.pnlShapes.Size = new System.Drawing.Size(101, 235);
            this.pnlShapes.TabIndex = 1;
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(0, 42);
            this.btnTriangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(101, 30);
            this.btnTriangle.TabIndex = 10;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(0, 80);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(101, 30);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(0, 118);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(101, 30);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(0, 158);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(101, 30);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(0, 196);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(101, 30);
            this.btnCircle.TabIndex = 4;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(0, 319);
            this.btnDeserialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(101, 30);
            this.btnDeserialize.TabIndex = 12;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(0, 281);
            this.btnSerialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(101, 30);
            this.btnSerialize.TabIndex = 11;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(0, 243);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear ALL";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPenWidth
            // 
            this.lblPenWidth.AutoSize = true;
            this.lblPenWidth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPenWidth.Location = new System.Drawing.Point(3, 735);
            this.lblPenWidth.Name = "lblPenWidth";
            this.lblPenWidth.Size = new System.Drawing.Size(97, 17);
            this.lblPenWidth.TabIndex = 8;
            this.lblPenWidth.Text = "Change Width";
            // 
            // tBarWidth
            // 
            this.tBarWidth.Location = new System.Drawing.Point(3, 753);
            this.tBarWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tBarWidth.Name = "tBarWidth";
            this.tBarWidth.Size = new System.Drawing.Size(95, 56);
            this.tBarWidth.TabIndex = 7;
            this.tBarWidth.Scroll += new System.EventHandler(this.tBarWidth_Scroll);
            // 
            // pnlCommon
            // 
            this.pnlCommon.Controls.Add(this.pnlCanvas);
            this.pnlCommon.Controls.Add(this.pnlButtons);
            this.pnlCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCommon.Location = new System.Drawing.Point(0, 0);
            this.pnlCommon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCommon.Name = "pnlCommon";
            this.pnlCommon.Size = new System.Drawing.Size(1240, 864);
            this.pnlCommon.TabIndex = 0;
            // 
            // comboBoxCustomShape
            // 
            this.comboBoxCustomShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomShape.FormattingEnabled = true;
            this.comboBoxCustomShape.Location = new System.Drawing.Point(0, 583);
            this.comboBoxCustomShape.Name = "comboBoxCustomShape";
            this.comboBoxCustomShape.Size = new System.Drawing.Size(101, 24);
            this.comboBoxCustomShape.TabIndex = 1;
            this.comboBoxCustomShape.SelectedIndexChanged += new System.EventHandler(this.btnCustomShape_Click);
            // 
            // btnDeleteShape
            // 
            this.btnDeleteShape.Location = new System.Drawing.Point(0, 614);
            this.btnDeleteShape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteShape.Name = "btnDeleteShape";
            this.btnDeleteShape.Size = new System.Drawing.Size(101, 26);
            this.btnDeleteShape.TabIndex = 13;
            this.btnDeleteShape.Text = "Delete";
            this.btnDeleteShape.UseVisualStyleBackColor = true;
            this.btnDeleteShape.Click += new System.EventHandler(this.btnDeleteShape_Click);
            // 
            // btnSaveShape
            // 
            this.btnSaveShape.Location = new System.Drawing.Point(0, 648);
            this.btnSaveShape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveShape.Name = "btnSaveShape";
            this.btnSaveShape.Size = new System.Drawing.Size(101, 26);
            this.btnSaveShape.TabIndex = 14;
            this.btnSaveShape.Text = "Save";
            this.btnSaveShape.UseVisualStyleBackColor = true;
            this.btnSaveShape.Click += new System.EventHandler(this.btnSaveShape_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 864);
            this.Controls.Add(this.pnlCommon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 319);
            this.Name = "MainForm";
            this.Text = "TheBestPaintEver";
            this.pnlCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShapePictureBox)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlPlugins.ResumeLayout(false);
            this.pnlShapes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tBarWidth)).EndInit();
            this.pnlCommon.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnChangeBackgroundColor;
        private System.Windows.Forms.Button btnCreateShape;
        private System.Windows.Forms.TextBox textBoxCustomShape;
        private System.Windows.Forms.Label lblCustomShape;
        private System.Windows.Forms.ComboBox comboBoxCustomShape;
        private System.Windows.Forms.Button btnSaveShape;
        private System.Windows.Forms.Button btnDeleteShape;
    }
}


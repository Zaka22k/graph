namespace Graph
{
    partial class Graph
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BackgroundPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.maximizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.hLabel = new System.Windows.Forms.Label();
            this.yintervalLabel = new System.Windows.Forms.Label();
            this.xintervalLabel = new System.Windows.Forms.Label();
            this.ymaxLabel = new System.Windows.Forms.Label();
            this.yminLabel = new System.Windows.Forms.Label();
            this.xmaxLabel = new System.Windows.Forms.Label();
            this.xminLabel = new System.Windows.Forms.Label();
            this.asexsLabel = new System.Windows.Forms.Label();
            this.functionLabel = new System.Windows.Forms.Label();
            this.hBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.yintervalBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.xintervalBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ymaxBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.yminBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.xmaxBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.xminBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.functionBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.BoxPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.parametersLabel = new System.Windows.Forms.Label();
            this.vSeparator = new Guna.UI2.WinForms.Guna2VSeparator();
            this.colorsButton = new Guna.UI2.WinForms.Guna2Button();
            this.asexsButton = new Guna.UI2.WinForms.Guna2Button();
            this.createButton = new Guna.UI2.WinForms.Guna2Button();
            this.delButton = new Guna.UI2.WinForms.Guna2Button();
            this.DockPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.colorPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.color6 = new Guna.UI2.WinForms.Guna2Button();
            this.color4 = new Guna.UI2.WinForms.Guna2Button();
            this.color5 = new Guna.UI2.WinForms.Guna2Button();
            this.color3 = new Guna.UI2.WinForms.Guna2Button();
            this.color2 = new Guna.UI2.WinForms.Guna2Button();
            this.color1 = new Guna.UI2.WinForms.Guna2Button();
            this.createLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.BoxPanel.SuspendLayout();
            this.DockPanel.SuspendLayout();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.AnimationInterval = 250;
            this.BorderlessForm.BorderRadius = 16;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BackgroundPanel.BorderRadius = 8;
            this.BackgroundPanel.BorderThickness = 1;
            this.BackgroundPanel.Controls.Add(this.minimizeButton);
            this.BackgroundPanel.Controls.Add(this.maximizeButton);
            this.BackgroundPanel.Controls.Add(this.closeButton);
            this.BackgroundPanel.Controls.Add(this.hLabel);
            this.BackgroundPanel.Controls.Add(this.yintervalLabel);
            this.BackgroundPanel.Controls.Add(this.xintervalLabel);
            this.BackgroundPanel.Controls.Add(this.ymaxLabel);
            this.BackgroundPanel.Controls.Add(this.yminLabel);
            this.BackgroundPanel.Controls.Add(this.xmaxLabel);
            this.BackgroundPanel.Controls.Add(this.xminLabel);
            this.BackgroundPanel.Controls.Add(this.asexsLabel);
            this.BackgroundPanel.Controls.Add(this.functionLabel);
            this.BackgroundPanel.Controls.Add(this.hBox);
            this.BackgroundPanel.Controls.Add(this.yintervalBox);
            this.BackgroundPanel.Controls.Add(this.xintervalBox);
            this.BackgroundPanel.Controls.Add(this.ymaxBox);
            this.BackgroundPanel.Controls.Add(this.yminBox);
            this.BackgroundPanel.Controls.Add(this.xmaxBox);
            this.BackgroundPanel.Controls.Add(this.xminBox);
            this.BackgroundPanel.Controls.Add(this.functionBox);
            this.BackgroundPanel.Controls.Add(this.titleLabel);
            this.BackgroundPanel.Controls.Add(this.IconBox);
            this.BackgroundPanel.Controls.Add(this.BoxPanel);
            this.BackgroundPanel.Controls.Add(this.DockPanel);
            this.BackgroundPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(999, 599);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimizeButton.FillColor = System.Drawing.Color.Empty;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.minimizeButton.Image = global::Graph.Properties.Resources.minimizeB;
            this.minimizeButton.ImageSize = new System.Drawing.Size(14, 14);
            this.minimizeButton.Location = new System.Drawing.Point(850, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(50, 32);
            this.minimizeButton.TabIndex = 19;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.maximizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.maximizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.maximizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.maximizeButton.FillColor = System.Drawing.Color.Empty;
            this.maximizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maximizeButton.ForeColor = System.Drawing.Color.White;
            this.maximizeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.maximizeButton.Image = global::Graph.Properties.Resources.maximizeB;
            this.maximizeButton.ImageSize = new System.Drawing.Size(14, 14);
            this.maximizeButton.Location = new System.Drawing.Point(900, 1);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(50, 32);
            this.maximizeButton.TabIndex = 18;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeButton.FillColor = System.Drawing.Color.Empty;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.closeButton.Image = global::Graph.Properties.Resources.closeB;
            this.closeButton.ImageSize = new System.Drawing.Size(14, 14);
            this.closeButton.Location = new System.Drawing.Point(950, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 32);
            this.closeButton.TabIndex = 17;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.BackColor = System.Drawing.Color.Transparent;
            this.hLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.hLabel.Location = new System.Drawing.Point(20, 520);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(110, 17);
            this.hLabel.TabIndex = 15;
            this.hLabel.Text = "Плотность точек:";
            // 
            // yintervalLabel
            // 
            this.yintervalLabel.AutoSize = true;
            this.yintervalLabel.BackColor = System.Drawing.Color.Transparent;
            this.yintervalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yintervalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.yintervalLabel.Location = new System.Drawing.Point(20, 460);
            this.yintervalLabel.Name = "yintervalLabel";
            this.yintervalLabel.Size = new System.Drawing.Size(99, 17);
            this.yintervalLabel.TabIndex = 15;
            this.yintervalLabel.Text = "Интервал по Y:";
            // 
            // xintervalLabel
            // 
            this.xintervalLabel.AutoSize = true;
            this.xintervalLabel.BackColor = System.Drawing.Color.Transparent;
            this.xintervalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xintervalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.xintervalLabel.Location = new System.Drawing.Point(20, 400);
            this.xintervalLabel.Name = "xintervalLabel";
            this.xintervalLabel.Size = new System.Drawing.Size(100, 17);
            this.xintervalLabel.TabIndex = 15;
            this.xintervalLabel.Text = "Интервал по X:";
            // 
            // ymaxLabel
            // 
            this.ymaxLabel.AutoSize = true;
            this.ymaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.ymaxLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ymaxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ymaxLabel.Location = new System.Drawing.Point(20, 340);
            this.ymaxLabel.Name = "ymaxLabel";
            this.ymaxLabel.Size = new System.Drawing.Size(113, 17);
            this.ymaxLabel.TabIndex = 15;
            this.ymaxLabel.Text = "Максимальный Y:";
            // 
            // yminLabel
            // 
            this.yminLabel.AutoSize = true;
            this.yminLabel.BackColor = System.Drawing.Color.Transparent;
            this.yminLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yminLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.yminLabel.Location = new System.Drawing.Point(20, 280);
            this.yminLabel.Name = "yminLabel";
            this.yminLabel.Size = new System.Drawing.Size(108, 17);
            this.yminLabel.TabIndex = 16;
            this.yminLabel.Text = "Минимальный Y:";
            // 
            // xmaxLabel
            // 
            this.xmaxLabel.AutoSize = true;
            this.xmaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.xmaxLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmaxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.xmaxLabel.Location = new System.Drawing.Point(20, 220);
            this.xmaxLabel.Name = "xmaxLabel";
            this.xmaxLabel.Size = new System.Drawing.Size(114, 17);
            this.xmaxLabel.TabIndex = 15;
            this.xmaxLabel.Text = "Максимальный X:";
            // 
            // xminLabel
            // 
            this.xminLabel.AutoSize = true;
            this.xminLabel.BackColor = System.Drawing.Color.Transparent;
            this.xminLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xminLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.xminLabel.Location = new System.Drawing.Point(20, 160);
            this.xminLabel.Name = "xminLabel";
            this.xminLabel.Size = new System.Drawing.Size(109, 17);
            this.xminLabel.TabIndex = 14;
            this.xminLabel.Text = "Минимальный X:";
            // 
            // asexsLabel
            // 
            this.asexsLabel.AutoSize = true;
            this.asexsLabel.BackColor = System.Drawing.Color.Transparent;
            this.asexsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asexsLabel.ForeColor = System.Drawing.Color.White;
            this.asexsLabel.Location = new System.Drawing.Point(36, 132);
            this.asexsLabel.Name = "asexsLabel";
            this.asexsLabel.Size = new System.Drawing.Size(127, 20);
            this.asexsLabel.TabIndex = 13;
            this.asexsLabel.Text = "Параметры осей";
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.BackColor = System.Drawing.Color.Transparent;
            this.functionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.functionLabel.ForeColor = System.Drawing.Color.White;
            this.functionLabel.Location = new System.Drawing.Point(64, 50);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(72, 20);
            this.functionLabel.TabIndex = 12;
            this.functionLabel.Text = "Функция";
            // 
            // hBox
            // 
            this.hBox.BackColor = System.Drawing.Color.Transparent;
            this.hBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.hBox.BorderRadius = 4;
            this.hBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hBox.DefaultText = "";
            this.hBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.hBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.hBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.hBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hBox.ForeColor = System.Drawing.Color.White;
            this.hBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.hBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.hBox.Location = new System.Drawing.Point(20, 540);
            this.hBox.Name = "hBox";
            this.hBox.PasswordChar = '\0';
            this.hBox.PlaceholderText = "";
            this.hBox.SelectedText = "";
            this.hBox.Size = new System.Drawing.Size(160, 32);
            this.hBox.TabIndex = 11;
            // 
            // yintervalBox
            // 
            this.yintervalBox.BackColor = System.Drawing.Color.Transparent;
            this.yintervalBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.yintervalBox.BorderRadius = 4;
            this.yintervalBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yintervalBox.DefaultText = "";
            this.yintervalBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.yintervalBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.yintervalBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yintervalBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yintervalBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.yintervalBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.yintervalBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.yintervalBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.yintervalBox.ForeColor = System.Drawing.Color.White;
            this.yintervalBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.yintervalBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.yintervalBox.Location = new System.Drawing.Point(20, 480);
            this.yintervalBox.Name = "yintervalBox";
            this.yintervalBox.PasswordChar = '\0';
            this.yintervalBox.PlaceholderText = "";
            this.yintervalBox.SelectedText = "";
            this.yintervalBox.Size = new System.Drawing.Size(160, 32);
            this.yintervalBox.TabIndex = 10;
            // 
            // xintervalBox
            // 
            this.xintervalBox.BackColor = System.Drawing.Color.Transparent;
            this.xintervalBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.xintervalBox.BorderRadius = 4;
            this.xintervalBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xintervalBox.DefaultText = "";
            this.xintervalBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.xintervalBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.xintervalBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.xintervalBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.xintervalBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.xintervalBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.xintervalBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.xintervalBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xintervalBox.ForeColor = System.Drawing.Color.White;
            this.xintervalBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.xintervalBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xintervalBox.Location = new System.Drawing.Point(20, 420);
            this.xintervalBox.Name = "xintervalBox";
            this.xintervalBox.PasswordChar = '\0';
            this.xintervalBox.PlaceholderText = "";
            this.xintervalBox.SelectedText = "";
            this.xintervalBox.Size = new System.Drawing.Size(160, 32);
            this.xintervalBox.TabIndex = 9;
            // 
            // ymaxBox
            // 
            this.ymaxBox.BackColor = System.Drawing.Color.Transparent;
            this.ymaxBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ymaxBox.BorderRadius = 4;
            this.ymaxBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ymaxBox.DefaultText = "";
            this.ymaxBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ymaxBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ymaxBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ymaxBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ymaxBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ymaxBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.ymaxBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ymaxBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ymaxBox.ForeColor = System.Drawing.Color.White;
            this.ymaxBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ymaxBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ymaxBox.Location = new System.Drawing.Point(20, 360);
            this.ymaxBox.Name = "ymaxBox";
            this.ymaxBox.PasswordChar = '\0';
            this.ymaxBox.PlaceholderText = "";
            this.ymaxBox.SelectedText = "";
            this.ymaxBox.Size = new System.Drawing.Size(160, 32);
            this.ymaxBox.TabIndex = 8;
            // 
            // yminBox
            // 
            this.yminBox.BackColor = System.Drawing.Color.Transparent;
            this.yminBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.yminBox.BorderRadius = 4;
            this.yminBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yminBox.DefaultText = "";
            this.yminBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.yminBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.yminBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yminBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.yminBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.yminBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.yminBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.yminBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.yminBox.ForeColor = System.Drawing.Color.White;
            this.yminBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.yminBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.yminBox.Location = new System.Drawing.Point(20, 300);
            this.yminBox.Name = "yminBox";
            this.yminBox.PasswordChar = '\0';
            this.yminBox.PlaceholderText = "";
            this.yminBox.SelectedText = "";
            this.yminBox.Size = new System.Drawing.Size(160, 32);
            this.yminBox.TabIndex = 7;
            // 
            // xmaxBox
            // 
            this.xmaxBox.BackColor = System.Drawing.Color.Transparent;
            this.xmaxBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.xmaxBox.BorderRadius = 4;
            this.xmaxBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xmaxBox.DefaultText = "";
            this.xmaxBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.xmaxBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.xmaxBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.xmaxBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.xmaxBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.xmaxBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.xmaxBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.xmaxBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xmaxBox.ForeColor = System.Drawing.Color.White;
            this.xmaxBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.xmaxBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xmaxBox.Location = new System.Drawing.Point(20, 240);
            this.xmaxBox.Name = "xmaxBox";
            this.xmaxBox.PasswordChar = '\0';
            this.xmaxBox.PlaceholderText = "";
            this.xmaxBox.SelectedText = "";
            this.xmaxBox.Size = new System.Drawing.Size(160, 32);
            this.xmaxBox.TabIndex = 6;
            // 
            // xminBox
            // 
            this.xminBox.BackColor = System.Drawing.Color.Transparent;
            this.xminBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.xminBox.BorderRadius = 4;
            this.xminBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.xminBox.DefaultText = "";
            this.xminBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.xminBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.xminBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.xminBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.xminBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.xminBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.xminBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.xminBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xminBox.ForeColor = System.Drawing.Color.White;
            this.xminBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.xminBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.xminBox.Location = new System.Drawing.Point(20, 180);
            this.xminBox.Name = "xminBox";
            this.xminBox.PasswordChar = '\0';
            this.xminBox.PlaceholderText = "";
            this.xminBox.SelectedText = "";
            this.xminBox.Size = new System.Drawing.Size(160, 32);
            this.xminBox.TabIndex = 5;
            // 
            // functionBox
            // 
            this.functionBox.BackColor = System.Drawing.Color.Transparent;
            this.functionBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.functionBox.BorderRadius = 4;
            this.functionBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.functionBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.functionBox.DefaultText = "";
            this.functionBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.functionBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.functionBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.functionBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.functionBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.functionBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.functionBox.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.functionBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.functionBox.ForeColor = System.Drawing.Color.White;
            this.functionBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.functionBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.functionBox.IconLeft = global::Graph.Properties.Resources.question;
            this.functionBox.IconLeftSize = new System.Drawing.Size(14, 14);
            this.functionBox.Location = new System.Drawing.Point(20, 80);
            this.functionBox.Name = "functionBox";
            this.functionBox.PasswordChar = '\0';
            this.functionBox.PlaceholderText = "";
            this.functionBox.SelectedText = "";
            this.functionBox.Size = new System.Drawing.Size(160, 32);
            this.functionBox.TabIndex = 4;
            this.functionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.functionBox.IconLeftClick += new System.EventHandler(this.functionBox_IconLeftClick);
            this.functionBox.Enter += new System.EventHandler(this.functionBox_Enter);
            this.functionBox.Leave += new System.EventHandler(this.functionBox_Leave);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(28, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(44, 17);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Graph";
            // 
            // IconBox
            // 
            this.IconBox.BackColor = System.Drawing.Color.Transparent;
            this.IconBox.Image = global::Graph.Properties.Resources.windows;
            this.IconBox.Location = new System.Drawing.Point(7, 7);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(18, 18);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconBox.TabIndex = 2;
            this.IconBox.TabStop = false;
            // 
            // BoxPanel
            // 
            this.BoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxPanel.BackColor = System.Drawing.Color.Transparent;
            this.BoxPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BoxPanel.BorderRadius = 8;
            this.BoxPanel.BorderThickness = 1;
            this.BoxPanel.Controls.Add(this.parametersLabel);
            this.BoxPanel.Controls.Add(this.vSeparator);
            this.BoxPanel.Controls.Add(this.colorsButton);
            this.BoxPanel.Controls.Add(this.asexsButton);
            this.BoxPanel.Controls.Add(this.createButton);
            this.BoxPanel.Controls.Add(this.delButton);
            this.BoxPanel.CustomizableEdges.BottomLeft = false;
            this.BoxPanel.CustomizableEdges.BottomRight = false;
            this.BoxPanel.CustomizableEdges.TopRight = false;
            this.BoxPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BoxPanel.Location = new System.Drawing.Point(200, 50);
            this.BoxPanel.Name = "BoxPanel";
            this.BoxPanel.Size = new System.Drawing.Size(799, 40);
            this.BoxPanel.TabIndex = 1;
            // 
            // parametersLabel
            // 
            this.parametersLabel.AutoSize = true;
            this.parametersLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parametersLabel.ForeColor = System.Drawing.Color.White;
            this.parametersLabel.Location = new System.Drawing.Point(10, 11);
            this.parametersLabel.Name = "parametersLabel";
            this.parametersLabel.Size = new System.Drawing.Size(136, 17);
            this.parametersLabel.TabIndex = 6;
            this.parametersLabel.Text = "Параметры графика";
            // 
            // vSeparator
            // 
            this.vSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vSeparator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.vSeparator.Location = new System.Drawing.Point(730, 5);
            this.vSeparator.Name = "vSeparator";
            this.vSeparator.Size = new System.Drawing.Size(1, 30);
            this.vSeparator.TabIndex = 4;
            // 
            // colorsButton
            // 
            this.colorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorsButton.BorderRadius = 4;
            this.colorsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.colorsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.colorsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.colorsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.colorsButton.FillColor = System.Drawing.Color.Empty;
            this.colorsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorsButton.ForeColor = System.Drawing.Color.White;
            this.colorsButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.colorsButton.Image = global::Graph.Properties.Resources.colorB;
            this.colorsButton.ImageSize = new System.Drawing.Size(16, 16);
            this.colorsButton.Location = new System.Drawing.Point(538, 2);
            this.colorsButton.Name = "colorsButton";
            this.colorsButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.colorsButton.Size = new System.Drawing.Size(60, 36);
            this.colorsButton.TabIndex = 3;
            this.ToolTip.SetToolTip(this.colorsButton, "Выбрать цвет графика");
            this.colorsButton.Click += new System.EventHandler(this.colorsButton_Click);
            // 
            // asexsButton
            // 
            this.asexsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.asexsButton.BorderRadius = 4;
            this.asexsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.asexsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.asexsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.asexsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.asexsButton.FillColor = System.Drawing.Color.Empty;
            this.asexsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.asexsButton.ForeColor = System.Drawing.Color.White;
            this.asexsButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.asexsButton.Image = global::Graph.Properties.Resources.axesB;
            this.asexsButton.ImageSize = new System.Drawing.Size(16, 16);
            this.asexsButton.Location = new System.Drawing.Point(603, 2);
            this.asexsButton.Name = "asexsButton";
            this.asexsButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.asexsButton.Size = new System.Drawing.Size(60, 36);
            this.asexsButton.TabIndex = 2;
            this.ToolTip.SetToolTip(this.asexsButton, "Разметить оси");
            this.asexsButton.Click += new System.EventHandler(this.asexsButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.BorderRadius = 4;
            this.createButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createButton.FillColor = System.Drawing.Color.Empty;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.createButton.Image = global::Graph.Properties.Resources.createB;
            this.createButton.ImageSize = new System.Drawing.Size(16, 16);
            this.createButton.Location = new System.Drawing.Point(668, 2);
            this.createButton.Name = "createButton";
            this.createButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.createButton.Size = new System.Drawing.Size(60, 36);
            this.createButton.TabIndex = 1;
            this.ToolTip.SetToolTip(this.createButton, "Построить график");
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.BorderRadius = 4;
            this.delButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delButton.FillColor = System.Drawing.Color.Empty;
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delButton.ForeColor = System.Drawing.Color.White;
            this.delButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(39)))), ((int)(((byte)(38)))));
            this.delButton.Image = global::Graph.Properties.Resources.delB;
            this.delButton.ImageSize = new System.Drawing.Size(16, 16);
            this.delButton.Location = new System.Drawing.Point(733, 2);
            this.delButton.Name = "delButton";
            this.delButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.delButton.Size = new System.Drawing.Size(60, 36);
            this.delButton.TabIndex = 0;
            this.ToolTip.SetToolTip(this.delButton, "Удалить график");
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // DockPanel
            // 
            this.DockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DockPanel.BackColor = System.Drawing.Color.Transparent;
            this.DockPanel.BorderRadius = 8;
            this.DockPanel.Controls.Add(this.colorPanel);
            this.DockPanel.Controls.Add(this.createLabel);
            this.DockPanel.Controls.Add(this.chart1);
            this.DockPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DockPanel.CustomBorderThickness = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.DockPanel.CustomizableEdges.BottomLeft = false;
            this.DockPanel.CustomizableEdges.TopRight = false;
            this.DockPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.DockPanel.Location = new System.Drawing.Point(200, 50);
            this.DockPanel.Name = "DockPanel";
            this.DockPanel.Size = new System.Drawing.Size(798, 547);
            this.DockPanel.TabIndex = 0;
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.colorPanel.BorderRadius = 8;
            this.colorPanel.BorderThickness = 1;
            this.colorPanel.Controls.Add(this.color6);
            this.colorPanel.Controls.Add(this.color4);
            this.colorPanel.Controls.Add(this.color5);
            this.colorPanel.Controls.Add(this.color3);
            this.colorPanel.Controls.Add(this.color2);
            this.colorPanel.Controls.Add(this.color1);
            this.colorPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.colorPanel.Location = new System.Drawing.Point(518, 46);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(100, 100);
            this.colorPanel.TabIndex = 2;
            this.colorPanel.Visible = false;
            this.colorPanel.Leave += new System.EventHandler(this.colorPanel_Leave);
            // 
            // color6
            // 
            this.color6.BorderRadius = 4;
            this.color6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.color6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.color6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.color6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.color6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(225)))), ((int)(((byte)(0)))));
            this.color6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.color6.ForeColor = System.Drawing.Color.White;
            this.color6.Location = new System.Drawing.Point(68, 52);
            this.color6.Name = "color6";
            this.color6.Size = new System.Drawing.Size(28, 28);
            this.color6.TabIndex = 11;
            this.color6.Click += new System.EventHandler(this.Color_Pick);
            // 
            // color4
            // 
            this.color4.BorderRadius = 4;
            this.color4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.color4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.color4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.color4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.color4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(203)))), ((int)(((byte)(95)))));
            this.color4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.color4.ForeColor = System.Drawing.Color.White;
            this.color4.Location = new System.Drawing.Point(36, 52);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(28, 28);
            this.color4.TabIndex = 10;
            this.color4.Click += new System.EventHandler(this.Color_Pick);
            // 
            // color5
            // 
            this.color5.BorderRadius = 4;
            this.color5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.color5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.color5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.color5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.color5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.color5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.color5.ForeColor = System.Drawing.Color.White;
            this.color5.Location = new System.Drawing.Point(4, 52);
            this.color5.Name = "color5";
            this.color5.Size = new System.Drawing.Size(28, 28);
            this.color5.TabIndex = 9;
            this.color5.Click += new System.EventHandler(this.Color_Pick);
            // 
            // color3
            // 
            this.color3.BorderRadius = 4;
            this.color3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.color3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.color3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.color3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.color3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.color3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.color3.ForeColor = System.Drawing.Color.White;
            this.color3.Location = new System.Drawing.Point(68, 20);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(28, 28);
            this.color3.TabIndex = 8;
            this.color3.Click += new System.EventHandler(this.Color_Pick);
            // 
            // color2
            // 
            this.color2.BorderRadius = 4;
            this.color2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.color2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.color2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.color2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.color2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(131)))), ((int)(((byte)(192)))));
            this.color2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.color2.ForeColor = System.Drawing.Color.White;
            this.color2.Location = new System.Drawing.Point(36, 20);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(28, 28);
            this.color2.TabIndex = 7;
            this.color2.Click += new System.EventHandler(this.Color_Pick);
            // 
            // color1
            // 
            this.color1.BorderRadius = 4;
            this.color1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.color1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.color1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.color1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.color1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.color1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.color1.ForeColor = System.Drawing.Color.White;
            this.color1.Location = new System.Drawing.Point(4, 20);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(28, 28);
            this.color1.TabIndex = 5;
            this.color1.Click += new System.EventHandler(this.Color_Pick);
            // 
            // createLabel
            // 
            this.createLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createLabel.ForeColor = System.Drawing.Color.White;
            this.createLabel.Location = new System.Drawing.Point(171, 268);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(455, 30);
            this.createLabel.TabIndex = 1;
            this.createLabel.Text = "Нажмите \"Построить\", чтобы вывести график";
            this.createLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-24, 36);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(831, 529);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ToolTip
            // 
            this.ToolTip.AllowLinksHandling = true;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ToolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // DragControl
            // 
            this.DragControl.DockForm = true;
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.BackgroundPanel;
            this.DragControl.UseTransparentDrag = true;
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            this.SizeChanged += new System.EventHandler(this.Graph_SizeChanged);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.BoxPanel.ResumeLayout(false);
            this.BoxPanel.PerformLayout();
            this.DockPanel.ResumeLayout(false);
            this.colorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2Panel BackgroundPanel;
        private Guna.UI2.WinForms.Guna2Panel DockPanel;
        private Guna.UI2.WinForms.Guna2Panel BoxPanel;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.Label yintervalLabel;
        private System.Windows.Forms.Label xintervalLabel;
        private System.Windows.Forms.Label ymaxLabel;
        private System.Windows.Forms.Label yminLabel;
        private System.Windows.Forms.Label xmaxLabel;
        private System.Windows.Forms.Label xminLabel;
        private System.Windows.Forms.Label asexsLabel;
        private System.Windows.Forms.Label functionLabel;
        private Guna.UI2.WinForms.Guna2TextBox hBox;
        private Guna.UI2.WinForms.Guna2TextBox yintervalBox;
        private Guna.UI2.WinForms.Guna2TextBox xintervalBox;
        private Guna.UI2.WinForms.Guna2TextBox ymaxBox;
        private Guna.UI2.WinForms.Guna2TextBox yminBox;
        private Guna.UI2.WinForms.Guna2TextBox xmaxBox;
        private Guna.UI2.WinForms.Guna2TextBox xminBox;
        private Guna.UI2.WinForms.Guna2TextBox functionBox;
        private System.Windows.Forms.Label titleLabel;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private Guna.UI2.WinForms.Guna2Button minimizeButton;
        private Guna.UI2.WinForms.Guna2Button maximizeButton;
        private Guna.UI2.WinForms.Guna2Button colorsButton;
        private Guna.UI2.WinForms.Guna2Button asexsButton;
        private Guna.UI2.WinForms.Guna2Button createButton;
        private Guna.UI2.WinForms.Guna2Button delButton;
        private Guna.UI2.WinForms.Guna2VSeparator vSeparator;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label createLabel;
        private Guna.UI2.WinForms.Guna2Panel colorPanel;
        private Guna.UI2.WinForms.Guna2Button color6;
        private Guna.UI2.WinForms.Guna2Button color4;
        private Guna.UI2.WinForms.Guna2Button color5;
        private Guna.UI2.WinForms.Guna2Button color3;
        private Guna.UI2.WinForms.Guna2Button color2;
        private Guna.UI2.WinForms.Guna2Button color1;
        private System.Windows.Forms.Label parametersLabel;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}


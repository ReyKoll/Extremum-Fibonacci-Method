
namespace MVPGraph
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBoxGraph = new System.Windows.Forms.GroupBox();
            this.chrtGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.lblEpsilon = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtEpsilon = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.groupBoxFunc = new System.Windows.Forms.GroupBox();
            this.rbtLine = new System.Windows.Forms.RadioButton();
            this.rbtParabola = new System.Windows.Forms.RadioButton();
            this.rbtCos = new System.Windows.Forms.RadioButton();
            this.rbtSin = new System.Windows.Forms.RadioButton();
            this.btDraw = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.txtMaxX = new System.Windows.Forms.TextBox();
            this.txtFX = new System.Windows.Forms.TextBox();
            this.txtMaxY = new System.Windows.Forms.TextBox();
            this.txtMinY = new System.Windows.Forms.TextBox();
            this.lblMaxX = new System.Windows.Forms.Label();
            this.lblFX = new System.Windows.Forms.Label();
            this.lblMaxY = new System.Windows.Forms.Label();
            this.lblMinY = new System.Windows.Forms.Label();
            this.rbtMax = new System.Windows.Forms.RadioButton();
            this.rbtMin = new System.Windows.Forms.RadioButton();
            this.groupBoxH = new System.Windows.Forms.GroupBox();
            this.groupBoxMinMax = new System.Windows.Forms.GroupBox();
            this.lblMinX = new System.Windows.Forms.Label();
            this.txtMinX = new System.Windows.Forms.TextBox();
            this.groupBoxGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGraph)).BeginInit();
            this.groupBoxSettings.SuspendLayout();
            this.groupBoxFunc.SuspendLayout();
            this.groupBoxH.SuspendLayout();
            this.groupBoxMinMax.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGraph
            // 
            this.groupBoxGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGraph.AutoSize = true;
            this.groupBoxGraph.Controls.Add(this.chrtGraph);
            this.groupBoxGraph.Location = new System.Drawing.Point(213, 12);
            this.groupBoxGraph.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxGraph.Name = "groupBoxGraph";
            this.groupBoxGraph.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxGraph.Size = new System.Drawing.Size(804, 466);
            this.groupBoxGraph.TabIndex = 0;
            this.groupBoxGraph.TabStop = false;
            this.groupBoxGraph.Text = "График функции";
            // 
            // chrtGraph
            // 
            this.chrtGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LabelStyle.Format = "0.00";
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea";
            this.chrtGraph.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend";
            this.chrtGraph.Legends.Add(legend1);
            this.chrtGraph.Location = new System.Drawing.Point(6, 19);
            this.chrtGraph.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chrtGraph.Name = "chrtGraph";
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Navy;
            series1.CustomProperties = "IsXAxisQuantitative=True";
            series1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsVisibleInLegend = false;
            series1.LabelFormat = "{0:0.00}";
            series1.Legend = "Legend";
            series1.Name = "Series";
            series1.ShadowColor = System.Drawing.Color.Black;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chrtGraph.Series.Add(series1);
            this.chrtGraph.Size = new System.Drawing.Size(792, 441);
            this.chrtGraph.TabIndex = 0;
            this.chrtGraph.Text = "chart";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add(this.lblEpsilon);
            this.groupBoxSettings.Controls.Add(this.lblB);
            this.groupBoxSettings.Controls.Add(this.lblA);
            this.groupBoxSettings.Controls.Add(this.txtEpsilon);
            this.groupBoxSettings.Controls.Add(this.txtB);
            this.groupBoxSettings.Controls.Add(this.txtA);
            this.groupBoxSettings.Location = new System.Drawing.Point(8, 204);
            this.groupBoxSettings.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxSettings.Size = new System.Drawing.Size(200, 263);
            this.groupBoxSettings.TabIndex = 1;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Интервал функции";
            // 
            // lblEpsilon
            // 
            this.lblEpsilon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEpsilon.AutoSize = true;
            this.lblEpsilon.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblEpsilon.Location = new System.Drawing.Point(45, 183);
            this.lblEpsilon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpsilon.Name = "lblEpsilon";
            this.lblEpsilon.Size = new System.Drawing.Size(109, 21);
            this.lblEpsilon.TabIndex = 7;
            this.lblEpsilon.Text = "ε (точность)";
            // 
            // lblB
            // 
            this.lblB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblB.Location = new System.Drawing.Point(64, 102);
            this.lblB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(64, 21);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "B (до) ";
            // 
            // lblA
            // 
            this.lblA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblA.Location = new System.Drawing.Point(64, 30);
            this.lblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(62, 21);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "A (от) ";
            // 
            // txtEpsilon
            // 
            this.txtEpsilon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEpsilon.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtEpsilon.Location = new System.Drawing.Point(49, 206);
            this.txtEpsilon.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtEpsilon.Name = "txtEpsilon";
            this.txtEpsilon.Size = new System.Drawing.Size(100, 29);
            this.txtEpsilon.TabIndex = 3;
            this.txtEpsilon.Tag = "0.001";
            this.txtEpsilon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEpsilon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEpsilon_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtB.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtB.Location = new System.Drawing.Point(49, 126);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 29);
            this.txtB.TabIndex = 1;
            this.txtB.Tag = "10";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtA.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtA.Location = new System.Drawing.Point(49, 54);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 29);
            this.txtA.TabIndex = 0;
            this.txtA.Tag = "-10";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtA_KeyPress);
            // 
            // lblH
            // 
            this.lblH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblH.Location = new System.Drawing.Point(64, 16);
            this.lblH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(71, 21);
            this.lblH.TabIndex = 6;
            this.lblH.Text = "h (шаг) ";
            // 
            // txtH
            // 
            this.txtH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtH.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtH.Location = new System.Drawing.Point(49, 41);
            this.txtH.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 29);
            this.txtH.TabIndex = 2;
            this.txtH.Tag = "0.1";
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtH_KeyPress);
            // 
            // groupBoxFunc
            // 
            this.groupBoxFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFunc.Controls.Add(this.rbtLine);
            this.groupBoxFunc.Controls.Add(this.rbtParabola);
            this.groupBoxFunc.Controls.Add(this.rbtCos);
            this.groupBoxFunc.Controls.Add(this.rbtSin);
            this.groupBoxFunc.Location = new System.Drawing.Point(8, 12);
            this.groupBoxFunc.Name = "groupBoxFunc";
            this.groupBoxFunc.Size = new System.Drawing.Size(200, 108);
            this.groupBoxFunc.TabIndex = 2;
            this.groupBoxFunc.TabStop = false;
            this.groupBoxFunc.Text = "Выбор функции";
            // 
            // rbtLine
            // 
            this.rbtLine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtLine.AutoSize = true;
            this.rbtLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbtLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtLine.Location = new System.Drawing.Point(112, 76);
            this.rbtLine.Name = "rbtLine";
            this.rbtLine.Size = new System.Drawing.Size(69, 20);
            this.rbtLine.TabIndex = 3;
            this.rbtLine.TabStop = true;
            this.rbtLine.Text = "y = x - 2";
            this.rbtLine.UseVisualStyleBackColor = true;
            // 
            // rbtParabola
            // 
            this.rbtParabola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtParabola.AutoSize = true;
            this.rbtParabola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtParabola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbtParabola.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtParabola.Location = new System.Drawing.Point(16, 76);
            this.rbtParabola.Name = "rbtParabola";
            this.rbtParabola.Size = new System.Drawing.Size(86, 20);
            this.rbtParabola.TabIndex = 2;
            this.rbtParabola.TabStop = true;
            this.rbtParabola.Text = "y = x * x - 4";
            this.rbtParabola.UseVisualStyleBackColor = true;
            // 
            // rbtCos
            // 
            this.rbtCos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtCos.AutoSize = true;
            this.rbtCos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbtCos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbtCos.Location = new System.Drawing.Point(112, 28);
            this.rbtCos.Name = "rbtCos";
            this.rbtCos.Size = new System.Drawing.Size(84, 20);
            this.rbtCos.TabIndex = 1;
            this.rbtCos.TabStop = true;
            this.rbtCos.Text = "y = Cos(x)";
            this.rbtCos.UseVisualStyleBackColor = true;
            // 
            // rbtSin
            // 
            this.rbtSin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtSin.AutoSize = true;
            this.rbtSin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbtSin.Location = new System.Drawing.Point(16, 28);
            this.rbtSin.Name = "rbtSin";
            this.rbtSin.Size = new System.Drawing.Size(79, 20);
            this.rbtSin.TabIndex = 0;
            this.rbtSin.TabStop = true;
            this.rbtSin.Text = "y = Sin(x)";
            this.rbtSin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtSin.UseVisualStyleBackColor = true;
            // 
            // btDraw
            // 
            this.btDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btDraw.Location = new System.Drawing.Point(213, 490);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(120, 62);
            this.btDraw.TabIndex = 3;
            this.btDraw.Text = "Построить";
            this.btDraw.UseVisualStyleBackColor = false;
            this.btDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnClear.Location = new System.Drawing.Point(358, 500);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(88, 40);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Очистить";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtMaxX
            // 
            this.txtMaxX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxX.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtMaxX.Location = new System.Drawing.Point(494, 507);
            this.txtMaxX.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMaxX.Name = "txtMaxX";
            this.txtMaxX.ReadOnly = true;
            this.txtMaxX.Size = new System.Drawing.Size(144, 29);
            this.txtMaxX.TabIndex = 9;
            this.txtMaxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFX
            // 
            this.txtFX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFX.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtFX.Location = new System.Drawing.Point(862, 506);
            this.txtFX.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtFX.Name = "txtFX";
            this.txtFX.ReadOnly = true;
            this.txtFX.Size = new System.Drawing.Size(144, 29);
            this.txtFX.TabIndex = 10;
            this.txtFX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaxY
            // 
            this.txtMaxY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxY.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtMaxY.Location = new System.Drawing.Point(655, 506);
            this.txtMaxY.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMaxY.Name = "txtMaxY";
            this.txtMaxY.ReadOnly = true;
            this.txtMaxY.Size = new System.Drawing.Size(144, 29);
            this.txtMaxY.TabIndex = 11;
            this.txtMaxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinY
            // 
            this.txtMinY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinY.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtMinY.Location = new System.Drawing.Point(655, 506);
            this.txtMinY.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMinY.Name = "txtMinY";
            this.txtMinY.ReadOnly = true;
            this.txtMinY.Size = new System.Drawing.Size(144, 29);
            this.txtMinY.TabIndex = 12;
            this.txtMinY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaxX
            // 
            this.lblMaxX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxX.AutoSize = true;
            this.lblMaxX.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblMaxX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMaxX.Location = new System.Drawing.Point(535, 482);
            this.lblMaxX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxX.Name = "lblMaxX";
            this.lblMaxX.Size = new System.Drawing.Size(61, 21);
            this.lblMaxX.TabIndex = 9;
            this.lblMaxX.Text = "Max X";
            // 
            // lblFX
            // 
            this.lblFX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFX.AutoSize = true;
            this.lblFX.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblFX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFX.Location = new System.Drawing.Point(914, 482);
            this.lblFX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFX.Name = "lblFX";
            this.lblFX.Size = new System.Drawing.Size(42, 21);
            this.lblFX.TabIndex = 13;
            this.lblFX.Text = "F(x)";
            // 
            // lblMaxY
            // 
            this.lblMaxY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxY.AutoSize = true;
            this.lblMaxY.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblMaxY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMaxY.Location = new System.Drawing.Point(701, 482);
            this.lblMaxY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxY.Name = "lblMaxY";
            this.lblMaxY.Size = new System.Drawing.Size(60, 21);
            this.lblMaxY.TabIndex = 14;
            this.lblMaxY.Text = "Max Y";
            // 
            // lblMinY
            // 
            this.lblMinY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinY.AutoSize = true;
            this.lblMinY.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblMinY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMinY.Location = new System.Drawing.Point(701, 482);
            this.lblMinY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinY.Name = "lblMinY";
            this.lblMinY.Size = new System.Drawing.Size(56, 21);
            this.lblMinY.TabIndex = 15;
            this.lblMinY.Text = "Min Y";
            // 
            // rbtMax
            // 
            this.rbtMax.AutoSize = true;
            this.rbtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtMax.Location = new System.Drawing.Point(44, 19);
            this.rbtMax.Name = "rbtMax";
            this.rbtMax.Size = new System.Drawing.Size(51, 20);
            this.rbtMax.TabIndex = 16;
            this.rbtMax.TabStop = true;
            this.rbtMax.Text = "Max";
            this.rbtMax.UseVisualStyleBackColor = true;
            // 
            // rbtMin
            // 
            this.rbtMin.AutoSize = true;
            this.rbtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtMin.Location = new System.Drawing.Point(101, 19);
            this.rbtMin.Name = "rbtMin";
            this.rbtMin.Size = new System.Drawing.Size(47, 20);
            this.rbtMin.TabIndex = 17;
            this.rbtMin.TabStop = true;
            this.rbtMin.Text = "Min";
            this.rbtMin.UseVisualStyleBackColor = true;
            // 
            // groupBoxH
            // 
            this.groupBoxH.Controls.Add(this.lblH);
            this.groupBoxH.Controls.Add(this.txtH);
            this.groupBoxH.Location = new System.Drawing.Point(8, 474);
            this.groupBoxH.Name = "groupBoxH";
            this.groupBoxH.Size = new System.Drawing.Size(200, 91);
            this.groupBoxH.TabIndex = 16;
            this.groupBoxH.TabStop = false;
            this.groupBoxH.Text = "Настройки графика";
            // 
            // groupBoxMinMax
            // 
            this.groupBoxMinMax.Controls.Add(this.rbtMax);
            this.groupBoxMinMax.Controls.Add(this.rbtMin);
            this.groupBoxMinMax.Location = new System.Drawing.Point(8, 126);
            this.groupBoxMinMax.Name = "groupBoxMinMax";
            this.groupBoxMinMax.Size = new System.Drawing.Size(200, 53);
            this.groupBoxMinMax.TabIndex = 18;
            this.groupBoxMinMax.TabStop = false;
            // 
            // lblMinX
            // 
            this.lblMinX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinX.AutoSize = true;
            this.lblMinX.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblMinX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMinX.Location = new System.Drawing.Point(535, 482);
            this.lblMinX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinX.Name = "lblMinX";
            this.lblMinX.Size = new System.Drawing.Size(57, 21);
            this.lblMinX.TabIndex = 20;
            this.lblMinX.Text = "Min X";
            // 
            // txtMinX
            // 
            this.txtMinX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinX.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtMinX.Location = new System.Drawing.Point(494, 507);
            this.txtMinX.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMinX.Name = "txtMinX";
            this.txtMinX.ReadOnly = true;
            this.txtMinX.Size = new System.Drawing.Size(144, 29);
            this.txtMinX.TabIndex = 21;
            this.txtMinX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1028, 577);
            this.Controls.Add(this.txtMinX);
            this.Controls.Add(this.lblMinX);
            this.Controls.Add(this.groupBoxMinMax);
            this.Controls.Add(this.groupBoxH);
            this.Controls.Add(this.lblMinY);
            this.Controls.Add(this.lblMaxY);
            this.Controls.Add(this.lblFX);
            this.Controls.Add(this.lblMaxX);
            this.Controls.Add(this.txtMinY);
            this.Controls.Add(this.txtMaxY);
            this.Controls.Add(this.txtFX);
            this.Controls.Add(this.txtMaxX);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.btDraw);
            this.Controls.Add(this.groupBoxFunc);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск экстремума функции методом Фибоначчи";
            this.groupBoxGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtGraph)).EndInit();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.groupBoxFunc.ResumeLayout(false);
            this.groupBoxFunc.PerformLayout();
            this.groupBoxH.ResumeLayout(false);
            this.groupBoxH.PerformLayout();
            this.groupBoxMinMax.ResumeLayout(false);
            this.groupBoxMinMax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGraph;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblEpsilon;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtEpsilon;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.GroupBox groupBoxFunc;
        private System.Windows.Forms.Button btDraw;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox txtMaxX;
        private System.Windows.Forms.TextBox txtFX;
        private System.Windows.Forms.TextBox txtMaxY;
        private System.Windows.Forms.TextBox txtMinY;
        private System.Windows.Forms.Label lblMaxX;
        private System.Windows.Forms.Label lblFX;
        private System.Windows.Forms.Label lblMaxY;
        private System.Windows.Forms.Label lblMinY;
        public System.Windows.Forms.DataVisualization.Charting.Chart chrtGraph;
        public System.Windows.Forms.RadioButton rbtLine;
        public System.Windows.Forms.RadioButton rbtParabola;
        public System.Windows.Forms.RadioButton rbtCos;
        public System.Windows.Forms.RadioButton rbtSin;
        public System.Windows.Forms.RadioButton rbtMax;
        public System.Windows.Forms.RadioButton rbtMin;
        private System.Windows.Forms.GroupBox groupBoxH;
        private System.Windows.Forms.GroupBox groupBoxMinMax;
        private System.Windows.Forms.Label lblMinX;
        private System.Windows.Forms.TextBox txtMinX;
    }
}


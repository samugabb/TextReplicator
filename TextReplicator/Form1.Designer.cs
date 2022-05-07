namespace TextReplicator
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGo = new MaterialSkin.Controls.MaterialButton();
            this.sliderTime = new MaterialSkin.Controls.MaterialSlider();
            this.btnHideShow = new MaterialSkin.Controls.MaterialButton();
            this.textBoxText = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnAIO = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.AutoSize = false;
            this.btnGo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGo.Depth = 0;
            this.btnGo.Enabled = false;
            this.btnGo.HighEmphasis = true;
            this.btnGo.Icon = null;
            this.btnGo.Location = new System.Drawing.Point(325, 77);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGo.Name = "btnGo";
            this.btnGo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGo.Size = new System.Drawing.Size(39, 48);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GO";
            this.btnGo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGo.UseAccentColor = false;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // sliderTime
            // 
            this.sliderTime.Depth = 0;
            this.sliderTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderTime.Location = new System.Drawing.Point(13, 131);
            this.sliderTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.sliderTime.Name = "sliderTime";
            this.sliderTime.RangeMax = 10;
            this.sliderTime.RangeMin = 1;
            this.sliderTime.Size = new System.Drawing.Size(501, 40);
            this.sliderTime.TabIndex = 3;
            this.sliderTime.Text = "wait time";
            this.sliderTime.UseAccentColor = true;
            this.sliderTime.Value = 3;
            this.sliderTime.ValueMax = 10;
            this.sliderTime.ValueSuffix = "s";
            // 
            // btnHideShow
            // 
            this.btnHideShow.AutoSize = false;
            this.btnHideShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHideShow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHideShow.Depth = 0;
            this.btnHideShow.HighEmphasis = true;
            this.btnHideShow.Icon = global::TextReplicator.Properties.Resources.eye_outline;
            this.btnHideShow.Location = new System.Drawing.Point(13, 77);
            this.btnHideShow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHideShow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHideShow.Name = "btnHideShow";
            this.btnHideShow.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHideShow.Size = new System.Drawing.Size(40, 48);
            this.btnHideShow.TabIndex = 4;
            this.btnHideShow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHideShow.UseAccentColor = false;
            this.btnHideShow.UseVisualStyleBackColor = true;
            this.btnHideShow.Click += new System.EventHandler(this.btnHideShow_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.AnimateReadOnly = false;
            this.textBoxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxText.Depth = 0;
            this.textBoxText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxText.Hint = "text to paste";
            this.textBoxText.LeadingIcon = null;
            this.textBoxText.Location = new System.Drawing.Point(60, 77);
            this.textBoxText.MaxLength = 50;
            this.textBoxText.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxText.Multiline = false;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Password = true;
            this.textBoxText.Size = new System.Drawing.Size(258, 50);
            this.textBoxText.TabIndex = 5;
            this.textBoxText.Text = "";
            this.textBoxText.TrailingIcon = null;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel1.Location = new System.Drawing.Point(413, 163);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 13);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Samuele Gabbrielli 2022";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Text Replicator";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // btnAIO
            // 
            this.btnAIO.AutoSize = false;
            this.btnAIO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAIO.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAIO.Depth = 0;
            this.btnAIO.HighEmphasis = true;
            this.btnAIO.Icon = null;
            this.btnAIO.Location = new System.Drawing.Point(372, 77);
            this.btnAIO.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAIO.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAIO.Name = "btnAIO";
            this.btnAIO.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAIO.Size = new System.Drawing.Size(142, 48);
            this.btnAIO.TabIndex = 7;
            this.btnAIO.Text = "copy from clipboard and GO";
            this.btnAIO.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAIO.UseAccentColor = false;
            this.btnAIO.UseVisualStyleBackColor = true;
            this.btnAIO.Click += new System.EventHandler(this.btnAIO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 179);
            this.Controls.Add(this.btnAIO);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.btnHideShow);
            this.Controls.Add(this.sliderTime);
            this.Controls.Add(this.btnGo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Replicator v2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnGo;
        private MaterialSkin.Controls.MaterialSlider sliderTime;
        private MaterialSkin.Controls.MaterialButton btnHideShow;
        private MaterialSkin.Controls.MaterialTextBox textBoxText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MaterialSkin.Controls.MaterialButton btnAIO;
    }
}



namespace PokiWord
{
    partial class MainForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.play = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PlayPanel = new System.Windows.Forms.Panel();
            this.card_guna = new Guna.UI2.WinForms.Guna2Panel();
            this.poke_name = new System.Windows.Forms.Label();
            this.poke_image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.poke_description = new System.Windows.Forms.Label();
            this.ok_box = new System.Windows.Forms.Panel();
            this.ok_text = new System.Windows.Forms.Label();
            this.answer_box = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.answer_text = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PlayPanel.SuspendLayout();
            this.card_guna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poke_image)).BeginInit();
            this.ok_box.SuspendLayout();
            this.answer_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = global::PokiWord.Properties.Resources.bg;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPanel.Controls.Add(this.play);
            this.MainPanel.Controls.Add(this.Logo);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1008, 701);
            this.MainPanel.TabIndex = 0;
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Image = global::PokiWord.Properties.Resources.play_button;
            this.play.Location = new System.Drawing.Point(405, 420);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(240, 228);
            this.play.TabIndex = 2;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo.Image = global::PokiWord.Properties.Resources.logo_w_subtitle;
            this.Logo.Location = new System.Drawing.Point(3, 75);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(1002, 295);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // PlayPanel
            // 
            this.PlayPanel.BackColor = System.Drawing.Color.Transparent;
            this.PlayPanel.BackgroundImage = global::PokiWord.Properties.Resources.bg;
            this.PlayPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayPanel.Controls.Add(this.title);
            this.PlayPanel.Controls.Add(this.card_guna);
            this.PlayPanel.Controls.Add(this.ok_box);
            this.PlayPanel.Controls.Add(this.answer_box);
            this.PlayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayPanel.Location = new System.Drawing.Point(0, 0);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(1008, 701);
            this.PlayPanel.TabIndex = 3;
            // 
            // card_guna
            // 
            this.card_guna.BackgroundImage = global::PokiWord.Properties.Resources.card;
            this.card_guna.Controls.Add(this.poke_name);
            this.card_guna.Controls.Add(this.poke_image);
            this.card_guna.Controls.Add(this.poke_description);
            this.card_guna.Location = new System.Drawing.Point(75, 61);
            this.card_guna.Name = "card_guna";
            this.card_guna.ShadowDecoration.Parent = this.card_guna;
            this.card_guna.Size = new System.Drawing.Size(435, 604);
            this.card_guna.TabIndex = 8;
            // 
            // poke_name
            // 
            this.poke_name.Font = new System.Drawing.Font("Arial Black", 15.25F, System.Drawing.FontStyle.Bold);
            this.poke_name.Location = new System.Drawing.Point(0, 14);
            this.poke_name.Name = "poke_name";
            this.poke_name.Size = new System.Drawing.Size(435, 54);
            this.poke_name.TabIndex = 2;
            this.poke_name.Text = "label2";
            this.poke_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poke_image
            // 
            this.poke_image.Location = new System.Drawing.Point(0, 85);
            this.poke_image.Name = "poke_image";
            this.poke_image.ShadowDecoration.Parent = this.poke_image;
            this.poke_image.Size = new System.Drawing.Size(435, 232);
            this.poke_image.TabIndex = 1;
            this.poke_image.TabStop = false;
            // 
            // poke_description
            // 
            this.poke_description.Font = new System.Drawing.Font("Arial", 12F);
            this.poke_description.Location = new System.Drawing.Point(17, 340);
            this.poke_description.Name = "poke_description";
            this.poke_description.Size = new System.Drawing.Size(402, 163);
            this.poke_description.TabIndex = 0;
            this.poke_description.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem " +
    "Ipsum has been the industry\'s standard dummy text ever since the 1500s,";
            this.poke_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ok_box
            // 
            this.ok_box.BackgroundImage = global::PokiWord.Properties.Resources.small_box;
            this.ok_box.Controls.Add(this.ok_text);
            this.ok_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_box.Location = new System.Drawing.Point(708, 493);
            this.ok_box.Name = "ok_box";
            this.ok_box.Size = new System.Drawing.Size(142, 56);
            this.ok_box.TabIndex = 7;
            // 
            // ok_text
            // 
            this.ok_text.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_text.Location = new System.Drawing.Point(0, 9);
            this.ok_text.Name = "ok_text";
            this.ok_text.Size = new System.Drawing.Size(141, 36);
            this.ok_text.TabIndex = 1;
            this.ok_text.Text = "OK";
            this.ok_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer_box
            // 
            this.answer_box.BackgroundImage = global::PokiWord.Properties.Resources.big_box;
            this.answer_box.Controls.Add(this.info);
            this.answer_box.Controls.Add(this.answer);
            this.answer_box.Controls.Add(this.answer_text);
            this.answer_box.Location = new System.Drawing.Point(601, 275);
            this.answer_box.Name = "answer_box";
            this.answer_box.Size = new System.Drawing.Size(359, 191);
            this.answer_box.TabIndex = 6;
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Arial", 10.75F);
            this.info.Location = new System.Drawing.Point(2, 138);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(356, 36);
            this.info.TabIndex = 2;
            this.info.Text = "use keyboard to type answer";
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.answer.Location = new System.Drawing.Point(1, 68);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(356, 62);
            this.answer.TabIndex = 1;
            this.answer.Text = "_ _ _ _ _";
            this.answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer_text
            // 
            this.answer_text.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.answer_text.Location = new System.Drawing.Point(3, 26);
            this.answer_text.Name = "answer_text";
            this.answer_text.Size = new System.Drawing.Size(356, 36);
            this.answer_text.TabIndex = 0;
            this.answer_text.Text = "Answer";
            this.answer_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Image = global::PokiWord.Properties.Resources.Guess_that_Pokemon2;
            this.title.Location = new System.Drawing.Point(659, 156);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(263, 113);
            this.title.TabIndex = 1;
            this.title.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 701);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.PlayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokiWord";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PlayPanel.ResumeLayout(false);
            this.card_guna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poke_image)).EndInit();
            this.ok_box.ResumeLayout(false);
            this.answer_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.Panel PlayPanel;
        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.Panel ok_box;
        private System.Windows.Forms.Panel answer_box;
        private System.Windows.Forms.Label ok_text;
        private System.Windows.Forms.Label answer_text;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Label info;
        private Guna.UI2.WinForms.Guna2Panel card_guna;
        private System.Windows.Forms.Label poke_name;
        private Guna.UI2.WinForms.Guna2PictureBox poke_image;
        private System.Windows.Forms.Label poke_description;
    }
}


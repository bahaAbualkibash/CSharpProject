
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation9 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.AnimatorNS.Animation animation10 = new Guna.UI2.AnimatorNS.Animation();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.LoginPnl = new Guna.UI.WinForms.GunaPanel();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.SignupButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.LoginButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaTextBox5 = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.LoginPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.gunaTransition1.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(0);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 1F;
            this.gunaTransition1.DefaultAnimation = animation9;
            // 
            // LoginPnl
            // 
            this.LoginPnl.Controls.Add(this.gunaLinkLabel1);
            this.LoginPnl.Controls.Add(this.gunaLabel4);
            this.LoginPnl.Controls.Add(this.SignupButton);
            this.LoginPnl.Controls.Add(this.gunaLabel3);
            this.LoginPnl.Controls.Add(this.gunaGradientButton3);
            this.LoginPnl.Controls.Add(this.gunaTextBox2);
            this.LoginPnl.Controls.Add(this.gunaTextBox1);
            this.LoginPnl.Controls.Add(this.gunaLabel1);
            this.LoginPnl.Controls.Add(this.gunaLabel2);
            this.LoginPnl.Controls.Add(this.gunaPictureBox1);
            this.guna2Transition1.SetDecoration(this.LoginPnl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.LoginPnl, Guna.UI.Animation.DecorationType.None);
            this.LoginPnl.Location = new System.Drawing.Point(0, 3);
            this.LoginPnl.Name = "LoginPnl";
            this.LoginPnl.Size = new System.Drawing.Size(857, 500);
            this.LoginPnl.TabIndex = 17;
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.gunaLinkLabel1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.gunaLinkLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaLinkLabel1, Guna.UI.Animation.DecorationType.None);
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.gunaLinkLabel1.Location = new System.Drawing.Point(299, 373);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(170, 21);
            this.gunaLinkLabel1.TabIndex = 22;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Forgot your password?";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.gunaLabel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaLabel4, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.gunaLabel4.Location = new System.Drawing.Point(279, 108);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(96, 21);
            this.gunaLabel4.TabIndex = 20;
            this.gunaLabel4.Text = "Let\'s Join Us";
            // 
            // SignupButton
            // 
            this.SignupButton.AnimationHoverSpeed = 0.07F;
            this.SignupButton.AnimationSpeed = 0.03F;
            this.SignupButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.SignupButton.BorderColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.SignupButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.SignupButton, Guna.UI.Animation.DecorationType.None);
            this.SignupButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignupButton.FocusedColor = System.Drawing.Color.Empty;
            this.SignupButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.SignupButton.Image = ((System.Drawing.Image)(resources.GetObject("SignupButton.Image")));
            this.SignupButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SignupButton.ImageSize = new System.Drawing.Size(30, 30);
            this.SignupButton.Location = new System.Drawing.Point(711, 25);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.SignupButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.SignupButton.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.SignupButton.OnHoverImage = null;
            this.SignupButton.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.SignupButton.Size = new System.Drawing.Size(121, 42);
            this.SignupButton.TabIndex = 19;
            this.SignupButton.Text = "Sign Up";
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.gunaLabel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaLabel3, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(275, 53);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(300, 45);
            this.gunaLabel3.TabIndex = 16;
            this.gunaLabel3.Text = "Here You Can Login";
            // 
            // gunaGradientButton3
            // 
            this.gunaGradientButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton3.AnimationSpeed = 0.03F;
            this.gunaGradientButton3.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(36)))), ((int)(((byte)(178)))));
            this.gunaGradientButton3.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(53)))), ((int)(((byte)(248)))));
            this.gunaGradientButton3.BorderColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.gunaGradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaGradientButton3, Guna.UI.Animation.DecorationType.None);
            this.gunaGradientButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton3.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton3.Image")));
            this.gunaGradientButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaGradientButton3.Location = new System.Drawing.Point(283, 316);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Size = new System.Drawing.Size(200, 45);
            this.gunaGradientButton3.TabIndex = 18;
            this.gunaGradientButton3.Text = "Login";
            this.gunaGradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.gunaTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(90)))));
            this.gunaTextBox2.BorderSize = 1;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.gunaTextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaTextBox2, Guna.UI.Animation.DecorationType.None);
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(283, 259);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(200, 36);
            this.gunaTextBox2.TabIndex = 17;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.gunaTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(90)))));
            this.gunaTextBox1.BorderSize = 1;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.gunaTextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaTextBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(283, 181);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(200, 36);
            this.gunaTextBox1.TabIndex = 16;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.gunaLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaLabel1, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.gunaLabel1.Location = new System.Drawing.Point(279, 157);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(48, 21);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "Email";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.gunaLabel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.gunaLabel2.Location = new System.Drawing.Point(279, 235);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(76, 21);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "Password";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.gunaPictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaPictureBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 422);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(857, 78);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaLabel9);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.LoginButton);
            this.gunaPanel1.Controls.Add(this.gunaLabel7);
            this.gunaPanel1.Controls.Add(this.gunaLabel6);
            this.gunaPanel1.Controls.Add(this.gunaLabel8);
            this.gunaPanel1.Controls.Add(this.gunaTextBox4);
            this.gunaPanel1.Controls.Add(this.gunaTextBox3);
            this.gunaPanel1.Controls.Add(this.gunaGradientButton1);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Controls.Add(this.gunaTextBox5);
            this.guna2Transition1.SetDecoration(this.gunaPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaPanel1, Guna.UI.Animation.DecorationType.None);
            this.gunaPanel1.Location = new System.Drawing.Point(3, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(854, 497);
            this.gunaPanel1.TabIndex = 23;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.gunaLabel9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaLabel9, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.gunaLabel9.Location = new System.Drawing.Point(279, 291);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(76, 21);
            this.gunaLabel9.TabIndex = 23;
            this.gunaLabel9.Text = "Password";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.gunaLabel5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaLabel5, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.gunaLabel5.Location = new System.Drawing.Point(279, 108);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(96, 21);
            this.gunaLabel5.TabIndex = 20;
            this.gunaLabel5.Text = "Let\'s Join Us";
            // 
            // LoginButton
            // 
            this.LoginButton.AnimationHoverSpeed = 0.07F;
            this.LoginButton.AnimationSpeed = 0.03F;
            this.LoginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.LoginButton.BorderColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.LoginButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.LoginButton, Guna.UI.Animation.DecorationType.None);
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginButton.FocusedColor = System.Drawing.Color.Empty;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.LoginButton.Image = ((System.Drawing.Image)(resources.GetObject("LoginButton.Image")));
            this.LoginButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LoginButton.ImageSize = new System.Drawing.Size(30, 30);
            this.LoginButton.Location = new System.Drawing.Point(711, 25);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.LoginButton.OnHoverImage = null;
            this.LoginButton.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.LoginButton.Size = new System.Drawing.Size(121, 42);
            this.LoginButton.TabIndex = 19;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.gunaLabel7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaLabel7, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.gunaLabel7.Location = new System.Drawing.Point(279, 135);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(52, 21);
            this.gunaLabel7.TabIndex = 11;
            this.gunaLabel7.Text = "Name";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.gunaLabel6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaLabel6, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(275, 53);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(333, 45);
            this.gunaLabel6.TabIndex = 16;
            this.gunaLabel6.Text = "Here You Can Sign Up";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.gunaLabel8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaLabel8, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(162)))));
            this.gunaLabel8.Location = new System.Drawing.Point(279, 213);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(48, 21);
            this.gunaLabel8.TabIndex = 12;
            this.gunaLabel8.Text = "Email";
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.gunaTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(90)))));
            this.gunaTextBox4.BorderSize = 1;
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.gunaTextBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaTextBox4, Guna.UI.Animation.DecorationType.None);
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox4.Location = new System.Drawing.Point(283, 159);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.SelectedText = "";
            this.gunaTextBox4.Size = new System.Drawing.Size(200, 36);
            this.gunaTextBox4.TabIndex = 16;
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.gunaTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(90)))));
            this.gunaTextBox3.BorderSize = 1;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.gunaTextBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaTextBox3, Guna.UI.Animation.DecorationType.None);
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox3.Location = new System.Drawing.Point(283, 237);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.SelectedText = "";
            this.gunaTextBox3.Size = new System.Drawing.Size(200, 36);
            this.gunaTextBox3.TabIndex = 17;
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(36)))), ((int)(((byte)(178)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(53)))), ((int)(((byte)(248)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.gunaGradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaGradientButton1, Guna.UI.Animation.DecorationType.None);
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaGradientButton1.Location = new System.Drawing.Point(283, 372);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(200, 45);
            this.gunaGradientButton1.TabIndex = 18;
            this.gunaGradientButton1.Text = "Sign Up";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.gunaPictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaPictureBox2, Guna.UI.Animation.DecorationType.None);
            this.gunaPictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(0, 419);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(854, 78);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 0;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaTextBox5
            // 
            this.gunaTextBox5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.gunaTextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(90)))));
            this.gunaTextBox5.BorderSize = 1;
            this.gunaTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.gunaTextBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.gunaTextBox5, Guna.UI.Animation.DecorationType.None);
            this.gunaTextBox5.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox5.Location = new System.Drawing.Point(283, 315);
            this.gunaTextBox5.Name = "gunaTextBox5";
            this.gunaTextBox5.PasswordChar = '\0';
            this.gunaTextBox5.SelectedText = "";
            this.gunaTextBox5.Size = new System.Drawing.Size(200, 36);
            this.gunaTextBox5.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoginPnl);
            this.panel1.Controls.Add(this.gunaPanel1);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaTransition1.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 500);
            this.panel1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.checkBox1, Guna.UI.Animation.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.checkBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.checkBox1.Location = new System.Drawing.Point(-15, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 0;
            animation10.Padding = new System.Windows.Forms.Padding(0);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(857, 500);
            this.Controls.Add(this.panel1);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPnl.ResumeLayout(false);
            this.LoginPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaPanel LoginPnl;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox5;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaButton LoginButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox4;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton SignupButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}


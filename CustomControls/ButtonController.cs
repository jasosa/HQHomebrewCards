using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HQHomebrewCards.CustomControls
{
    public partial class ButtonController : UserControl
    {
        public ButtonController()
        {
            InitializeComponent();
        }

      
        [Browsable(true)]
        public event EventHandler<ButtonPressedEventArgs> ButtonPressed;

        [Browsable(true)]
        public event EventHandler<ButtonUnPressedEventArgs> ButtonUnPressed;

        [Browsable(true)]
        public event EventHandler<EventArgs> ButtonCenterClick;

        [Browsable(true)]
        public bool ButtonUpVisible { get => btUp.Visible; set => btUp.Visible = value; }

        [Browsable(true)]
        public bool ButtonDownVisible { get => btDown.Visible; set => btDown.Visible = value; }

        [Browsable(true)]
        public bool ButtonLeftVisible { get => btLeft.Visible; set => btLeft.Visible = value; }

        [Browsable(true)]
        public bool ButtonRightVisible { get => btRight.Visible; set => btRight.Visible = value; }

        [Browsable(true)]
        public bool ButtonCenterVisible { get => btCenter.Visible; set => btCenter.Visible = value; }

        internal virtual void OnButtonPressed(ButtonPressedEventArgs e)
        {
            ButtonPressed?.Invoke(this, e);
        }

        internal virtual void OnButtonUnPressed(ButtonUnPressedEventArgs e)
        {
            ButtonUnPressed?.Invoke(this, e);
        }

        internal virtual void OnButtonCenterClick(EventArgs e)
        {
            ButtonCenterClick?.Invoke(this, e);
        }

        private void btLeft_MouseDown(object sender, MouseEventArgs e)
        {
            OnButtonPressed(new ButtonPressedEventArgs(MOVEMENT_DIRECTION.LEFT));
        }

        private void btLeft_MouseUp(object sender, MouseEventArgs e)
        {
            OnButtonUnPressed(new ButtonUnPressedEventArgs());
        }

        private void btUp_MouseDown(object sender, MouseEventArgs e)
        {
            OnButtonPressed(new ButtonPressedEventArgs(MOVEMENT_DIRECTION.UP));
        }

        private void btUp_MouseUp(object sender, MouseEventArgs e)
        {
            OnButtonUnPressed(new ButtonUnPressedEventArgs());
        }

        private void btDown_MouseDown(object sender, MouseEventArgs e)
        {
            OnButtonPressed(new ButtonPressedEventArgs(MOVEMENT_DIRECTION.DOWN));
        }

        private void btDown_MouseUp(object sender, MouseEventArgs e)
        {
            OnButtonUnPressed(new ButtonUnPressedEventArgs());
        }

        private void btRight_MouseDown(object sender, MouseEventArgs e)
        {
            OnButtonPressed(new ButtonPressedEventArgs(MOVEMENT_DIRECTION.RIGHT));
        }

        private void btRight_MouseUp(object sender, MouseEventArgs e)
        {
            OnButtonUnPressed(new ButtonUnPressedEventArgs());
        }

        private void btCenter_Click(object sender, EventArgs e)
        {
            OnButtonCenterClick(e);
        }
    }
}

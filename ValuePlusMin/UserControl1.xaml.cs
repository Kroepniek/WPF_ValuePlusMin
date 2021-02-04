using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.Generic;

namespace ValuePlusMin
{
    public partial class ValuePlusMinControl : UserControl
    {
        public static readonly DependencyProperty MinProperty = DependencyProperty.Register("Min", typeof(float), typeof(ValuePlusMinControl), new FrameworkPropertyMetadata(0.00f, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnMinChanged), new CoerceValueCallback(CoerceMinReading)), IsValidReading);
        public static readonly DependencyProperty MaxProperty = DependencyProperty.Register("Max", typeof(float), typeof(ValuePlusMinControl), new FrameworkPropertyMetadata(10.00f, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnMaxChanged), new CoerceValueCallback(CoerceMaxReading)), IsValidReading);
        public static readonly DependencyProperty StepProperty = DependencyProperty.Register("Step", typeof(float), typeof(ValuePlusMinControl), new FrameworkPropertyMetadata(1.00f, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnStepChanged), new CoerceValueCallback(CoerceStepReading)), IsValidReading);
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(float), typeof(ValuePlusMinControl), new FrameworkPropertyMetadata(0.00f, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnValueChanged), new CoerceValueCallback(CoerceValueReading)), IsValidReading);

        [Description("Value properties"), Category("Value")]
        public float Min
        {
            get { return (float)GetValue(MinProperty); }
            set { SetValue(MinProperty, value); }
        }
        [Description("Value properties"), Category("Value")]
        public float Max
        {
            get { return (float)GetValue(MaxProperty); }
            set { SetValue(MaxProperty, value); }
        }
        [Description("Value properties"), Category("Value")]
        public float Step
        {
            get { return (float)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }
        [Description("Value properties"), Category("Value")]
        public float Value
        {
            get { return (float)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        private readonly List<Key> acceptableKeys = new List<Key>()
        {
            Key.Space, Key.Back, Key.Delete, Key.OemComma, Key.Decimal, Key.OemMinus, Key.Subtract, Key.Left, Key.Right
        };

        public ValuePlusMinControl()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void CheckAndSetValue(object a_fNewValue)
        {
            if (float.TryParse(a_fNewValue.ToString(), out float m_fTryParseNewValue))
            {
                if (m_fTryParseNewValue >= Min && m_fTryParseNewValue <= Max)
                {
                    Value = m_fTryParseNewValue;
                }
                else
                {
                    if (m_fTryParseNewValue < Min)
                    {
                        Value = Min;
                    }
                    else
                    {
                        Value = Max;
                    }
                }
            }
        }


        public static bool IsValidReading(object a_fValue)
        {
            return float.TryParse(a_fValue.ToString(), out float m_fTryParseNewValue);
        }

        #region Dependency Properties Changed Events

        private static void OnMinChanged(DependencyObject a_dObject, DependencyPropertyChangedEventArgs e)
        {
            a_dObject.CoerceValue(MaxProperty);
            a_dObject.CoerceValue(ValueProperty);
        }

        private static void OnMaxChanged(DependencyObject a_dObject, DependencyPropertyChangedEventArgs e)
        {
            a_dObject.CoerceValue(ValueProperty);
        }

        private static void OnStepChanged(DependencyObject a_dObject, DependencyPropertyChangedEventArgs e)
        {
            a_dObject.CoerceValue(MinProperty);
            a_dObject.CoerceValue(MaxProperty);

        }

        private static void OnValueChanged(DependencyObject a_dObject, DependencyPropertyChangedEventArgs e)
        {
            
        }

        #endregion

        #region Dependency Properties Coerce Methods

        private static object CoerceMinReading(DependencyObject a_dObject, object a_fValue)
        {
            ValuePlusMinControl m_Control = (ValuePlusMinControl)a_dObject;

            float m_fValue = (float)a_fValue;

            if (m_fValue > m_Control.Max) m_fValue = float.MinValue;

            return m_fValue;
        }

        private static object CoerceMaxReading(DependencyObject a_dObject, object a_fValue)
        {
            ValuePlusMinControl m_Control = (ValuePlusMinControl)a_dObject;

            float m_fValue = (float)a_fValue;

            if (m_fValue < m_Control.Min) m_fValue = float.MaxValue;

            return m_fValue;
        }

        private static object CoerceStepReading(DependencyObject a_dObject, object a_fValue)
        {
            ValuePlusMinControl m_Control = (ValuePlusMinControl)a_dObject;

            float m_fValue = (float)a_fValue;
            float m_fDifferenceMinMax = (m_Control.Max - m_Control.Min);

            if (m_fValue > m_fDifferenceMinMax) m_fValue = m_fDifferenceMinMax;

            return m_fValue;
        }

        private static object CoerceValueReading(DependencyObject a_dObject, object a_fValue)
        {
            ValuePlusMinControl m_Control = (ValuePlusMinControl)a_dObject;

            float m_fValue = (float)a_fValue;

            if (m_fValue < m_Control.Min) m_fValue = m_Control.Min;
            if (m_fValue > m_Control.Max) m_fValue = m_Control.Max;

            return m_fValue;
        }

        #endregion

        #region Control events

        private void tbxValue_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!(acceptableKeys.Contains(e.Key) || (e.Key >= Key.D0 && e.Key <= Key.D9) ||
                (Keyboard.IsKeyDown(Key.LeftCtrl) && (e.Key == Key.C || e.Key == Key.V || e.Key == Key.A))))
            {
                if (e.Key == Key.Enter)
                {
                    CheckAndSetValue(tbxValue.Text);
                }

                e.Handled = true;
            }
        }

        private void tbxValue_LostFocus(object sender, RoutedEventArgs e)
        {
            CheckAndSetValue(tbxValue.Text);
        }

        private void btnMin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            float m_fTempNewValue = Value - Step;

            CheckAndSetValue(m_fTempNewValue);
        }

        private void btnPlus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            float m_fTempNewValue = Value + Step;

            CheckAndSetValue(m_fTempNewValue);
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace APP_HAS
{ 
    if (System is null)
        {
            throw private new ArgumentNullException(NameofNewStruct);

    internal struct NewStruct
    {
        private SystemPens item1;
        private object item2;

        public SystemPens Item1 { get => item1; set => item1 = value; }
        public object Item2 { get => item2; set => item2 = value; }

        public NewStruct(SystemPens item1, object item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   EqualityComparer<SystemPens>.Default.Equals(Item1, other.Item1) &&
                   EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            int hashCode = -1030903623;
            hashCode = hashCode * -1521134295 + EqualityComparer<SystemPens>.Default.GetHashCode(Item1);
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Item2);
            return hashCode;
        }

        public void Deconstruct(out SystemPens item1, out object item2)
        {
            item1 = Item1;
            item2 = Item2;
        }

        public static implicit operator (SystemPens, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((SystemPens, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}

    public partial class ValidaciónDatos : Form
{
    public ValidaciónDatos()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}


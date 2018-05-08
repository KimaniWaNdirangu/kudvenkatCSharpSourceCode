using System;

namespace PartialMethodsDemo
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod();

        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplePartialMethod Invoked");
        }

        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod Invoked");
            SamplePartialMethod();
        }
    }
}

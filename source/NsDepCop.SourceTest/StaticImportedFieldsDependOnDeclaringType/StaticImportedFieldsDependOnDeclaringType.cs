using static A.ClassA;

namespace B
{
    public class ClassB
    {
        public byte[] ReadField()
        {
            return Fingerprint;
        }

        public int ReadConstant()
        {
            return Count;
        }

        public byte[] ReadLocal()
        {
            byte[] Fingerprint = new byte[0];
            return Fingerprint;
        }
    }
}

namespace A
{
    public class ClassA
    {
        public static readonly byte[] Fingerprint = new byte[0];
        public const int Count = 3;
    }
}

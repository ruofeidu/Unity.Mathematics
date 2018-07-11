// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestBool3x3
    {
        [Test]
        public void bool3x3_operator_equal_wide_wide()
        {
            bool3x3 a0 = bool3x3(true, false, false);
            bool3x3 b0 = bool3x3(false, false, true);
            bool3x3 r0 = bool3x3(false, true, false);
            TestUtils.AreEqual(a0 == b0, r0);

            bool3x3 a1 = bool3x3(false, false, true);
            bool3x3 b1 = bool3x3(false, true, true);
            bool3x3 r1 = bool3x3(true, false, true);
            TestUtils.AreEqual(a1 == b1, r1);

            bool3x3 a2 = bool3x3(false, false, true);
            bool3x3 b2 = bool3x3(false, true, true);
            bool3x3 r2 = bool3x3(true, false, true);
            TestUtils.AreEqual(a2 == b2, r2);

            bool3x3 a3 = bool3x3(false, true, false);
            bool3x3 b3 = bool3x3(false, true, false);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void bool3x3_operator_equal_wide_scalar()
        {
            bool3x3 a0 = bool3x3(true, false, false);
            bool b0 = (false);
            bool3x3 r0 = bool3x3(false, true, true);
            TestUtils.AreEqual(a0 == b0, r0);

            bool3x3 a1 = bool3x3(false, false, false);
            bool b1 = (true);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            bool3x3 a2 = bool3x3(false, true, true);
            bool b2 = (true);
            bool3x3 r2 = bool3x3(false, true, true);
            TestUtils.AreEqual(a2 == b2, r2);

            bool3x3 a3 = bool3x3(false, false, true);
            bool b3 = (false);
            bool3x3 r3 = bool3x3(true, true, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void bool3x3_operator_equal_scalar_wide()
        {
            bool a0 = (true);
            bool3x3 b0 = bool3x3(false, false, false);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            bool a1 = (false);
            bool3x3 b1 = bool3x3(true, false, false);
            bool3x3 r1 = bool3x3(false, true, true);
            TestUtils.AreEqual(a1 == b1, r1);

            bool a2 = (false);
            bool3x3 b2 = bool3x3(true, true, true);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            bool a3 = (false);
            bool3x3 b3 = bool3x3(false, false, true);
            bool3x3 r3 = bool3x3(true, true, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void bool3x3_operator_not_equal_wide_wide()
        {
            bool3x3 a0 = bool3x3(true, false, false);
            bool3x3 b0 = bool3x3(false, false, true);
            bool3x3 r0 = bool3x3(true, false, true);
            TestUtils.AreEqual(a0 != b0, r0);

            bool3x3 a1 = bool3x3(false, false, true);
            bool3x3 b1 = bool3x3(false, true, true);
            bool3x3 r1 = bool3x3(false, true, false);
            TestUtils.AreEqual(a1 != b1, r1);

            bool3x3 a2 = bool3x3(false, false, true);
            bool3x3 b2 = bool3x3(false, true, true);
            bool3x3 r2 = bool3x3(false, true, false);
            TestUtils.AreEqual(a2 != b2, r2);

            bool3x3 a3 = bool3x3(false, true, false);
            bool3x3 b3 = bool3x3(false, true, false);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void bool3x3_operator_not_equal_wide_scalar()
        {
            bool3x3 a0 = bool3x3(true, false, false);
            bool b0 = (false);
            bool3x3 r0 = bool3x3(true, false, false);
            TestUtils.AreEqual(a0 != b0, r0);

            bool3x3 a1 = bool3x3(false, false, false);
            bool b1 = (true);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            bool3x3 a2 = bool3x3(false, true, true);
            bool b2 = (true);
            bool3x3 r2 = bool3x3(true, false, false);
            TestUtils.AreEqual(a2 != b2, r2);

            bool3x3 a3 = bool3x3(false, false, true);
            bool b3 = (false);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void bool3x3_operator_not_equal_scalar_wide()
        {
            bool a0 = (true);
            bool3x3 b0 = bool3x3(false, false, false);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            bool a1 = (false);
            bool3x3 b1 = bool3x3(true, false, false);
            bool3x3 r1 = bool3x3(true, false, false);
            TestUtils.AreEqual(a1 != b1, r1);

            bool a2 = (false);
            bool3x3 b2 = bool3x3(true, true, true);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            bool a3 = (false);
            bool3x3 b3 = bool3x3(false, false, true);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void bool3x3_operator_bitwise_and_wide_wide()
        {
            bool3x3 a0 = bool3x3(true, false, false);
            bool3x3 b0 = bool3x3(false, false, true);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 & b0, r0);

            bool3x3 a1 = bool3x3(false, false, true);
            bool3x3 b1 = bool3x3(false, true, true);
            bool3x3 r1 = bool3x3(false, false, true);
            TestUtils.AreEqual(a1 & b1, r1);

            bool3x3 a2 = bool3x3(false, false, true);
            bool3x3 b2 = bool3x3(false, true, true);
            bool3x3 r2 = bool3x3(false, false, true);
            TestUtils.AreEqual(a2 & b2, r2);

            bool3x3 a3 = bool3x3(false, true, false);
            bool3x3 b3 = bool3x3(false, true, false);
            bool3x3 r3 = bool3x3(false, true, false);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void bool3x3_operator_bitwise_and_wide_scalar()
        {
            bool3x3 a0 = bool3x3(true, false, false);
            bool b0 = (false);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 & b0, r0);

            bool3x3 a1 = bool3x3(false, false, false);
            bool b1 = (true);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 & b1, r1);

            bool3x3 a2 = bool3x3(false, true, true);
            bool b2 = (true);
            bool3x3 r2 = bool3x3(false, true, true);
            TestUtils.AreEqual(a2 & b2, r2);

            bool3x3 a3 = bool3x3(false, false, true);
            bool b3 = (false);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void bool3x3_operator_bitwise_and_scalar_wide()
        {
            bool a0 = (true);
            bool3x3 b0 = bool3x3(false, false, false);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 & b0, r0);

            bool a1 = (false);
            bool3x3 b1 = bool3x3(true, false, false);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 & b1, r1);

            bool a2 = (false);
            bool3x3 b2 = bool3x3(true, true, true);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 & b2, r2);

            bool a3 = (false);
            bool3x3 b3 = bool3x3(false, false, true);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void bool3x3_operator_bitwise_or_wide_wide()
        {
            bool3x3 a0 = bool3x3(true, false, false);
            bool3x3 b0 = bool3x3(false, false, true);
            bool3x3 r0 = bool3x3(true, false, true);
            TestUtils.AreEqual(a0 | b0, r0);

            bool3x3 a1 = bool3x3(false, false, true);
            bool3x3 b1 = bool3x3(false, true, true);
            bool3x3 r1 = bool3x3(false, true, true);
            TestUtils.AreEqual(a1 | b1, r1);

            bool3x3 a2 = bool3x3(false, false, true);
            bool3x3 b2 = bool3x3(false, true, true);
            bool3x3 r2 = bool3x3(false, true, true);
            TestUtils.AreEqual(a2 | b2, r2);

            bool3x3 a3 = bool3x3(false, true, false);
            bool3x3 b3 = bool3x3(false, true, false);
            bool3x3 r3 = bool3x3(false, true, false);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void bool3x3_operator_bitwise_or_wide_scalar()
        {
            bool3x3 a0 = bool3x3(true, false, false);
            bool b0 = (false);
            bool3x3 r0 = bool3x3(true, false, false);
            TestUtils.AreEqual(a0 | b0, r0);

            bool3x3 a1 = bool3x3(false, false, false);
            bool b1 = (true);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 | b1, r1);

            bool3x3 a2 = bool3x3(false, true, true);
            bool b2 = (true);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 | b2, r2);

            bool3x3 a3 = bool3x3(false, false, true);
            bool b3 = (false);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void bool3x3_operator_bitwise_or_scalar_wide()
        {
            bool a0 = (true);
            bool3x3 b0 = bool3x3(false, false, false);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 | b0, r0);

            bool a1 = (false);
            bool3x3 b1 = bool3x3(true, false, false);
            bool3x3 r1 = bool3x3(true, false, false);
            TestUtils.AreEqual(a1 | b1, r1);

            bool a2 = (false);
            bool3x3 b2 = bool3x3(true, true, true);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 | b2, r2);

            bool a3 = (false);
            bool3x3 b3 = bool3x3(false, false, true);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void bool3x3_operator_bitwise_xor_wide_wide()
        {
            bool3x3 a0 = bool3x3(true, false, false);
            bool3x3 b0 = bool3x3(false, false, true);
            bool3x3 r0 = bool3x3(true, false, true);
            TestUtils.AreEqual(a0 ^ b0, r0);

            bool3x3 a1 = bool3x3(false, false, true);
            bool3x3 b1 = bool3x3(false, true, true);
            bool3x3 r1 = bool3x3(false, true, false);
            TestUtils.AreEqual(a1 ^ b1, r1);

            bool3x3 a2 = bool3x3(false, false, true);
            bool3x3 b2 = bool3x3(false, true, true);
            bool3x3 r2 = bool3x3(false, true, false);
            TestUtils.AreEqual(a2 ^ b2, r2);

            bool3x3 a3 = bool3x3(false, true, false);
            bool3x3 b3 = bool3x3(false, true, false);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void bool3x3_operator_bitwise_xor_wide_scalar()
        {
            bool3x3 a0 = bool3x3(true, false, false);
            bool b0 = (false);
            bool3x3 r0 = bool3x3(true, false, false);
            TestUtils.AreEqual(a0 ^ b0, r0);

            bool3x3 a1 = bool3x3(false, false, false);
            bool b1 = (true);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 ^ b1, r1);

            bool3x3 a2 = bool3x3(false, true, true);
            bool b2 = (true);
            bool3x3 r2 = bool3x3(true, false, false);
            TestUtils.AreEqual(a2 ^ b2, r2);

            bool3x3 a3 = bool3x3(false, false, true);
            bool b3 = (false);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void bool3x3_operator_bitwise_xor_scalar_wide()
        {
            bool a0 = (true);
            bool3x3 b0 = bool3x3(false, false, false);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 ^ b0, r0);

            bool a1 = (false);
            bool3x3 b1 = bool3x3(true, false, false);
            bool3x3 r1 = bool3x3(true, false, false);
            TestUtils.AreEqual(a1 ^ b1, r1);

            bool a2 = (false);
            bool3x3 b2 = bool3x3(true, true, true);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 ^ b2, r2);

            bool a3 = (false);
            bool3x3 b3 = bool3x3(false, false, true);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }


    }
}

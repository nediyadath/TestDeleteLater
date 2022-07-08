using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{

//Partially abstract
public abstract class MyAbstractClass
    {
        public void M2() { }
        void m1() {
            Console.Write("Implemented");
        }

    }

    public class MyClass: MyAbstractClass
    {
    }

    //Completely abstract
    public interface IBilling
    {
        void Estimate(float price);
        void Discount(string custType);
        void Receipt(float totalPrice);

    }
    public partial class Billing : IBilling
    {
        public void Discount(string custType)
        {
            throw new NotImplementedException();
        }

    }

    public partial class Billing: IBilling
    {
        public void Estimate(float price)
        {
            throw new NotImplementedException();
        }

    }

    public partial class Billing
    {
        public void Receipt(float totalPrice)
        {
            throw new NotImplementedException();
        }
    }
}

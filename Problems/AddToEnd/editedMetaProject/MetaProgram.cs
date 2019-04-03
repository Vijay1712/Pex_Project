using System.Text.RegularExpressions;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Settings;

using System.Diagnostics;
namespace MetaProject
{
    [PexClass(typeof(MetaProgram))]
    public partial class MetaProgram
    {

        public class List
        {
            public int value;
            public List next;

            public List() { }

            public List(int setValue)
            {
                value = setValue;
            }

            /**
             * Add a value as the last item in the list.
             *
             * Can be called on any item of the list, although will normally be called
             * on the first item.
             */
            public virtual void addToEnd(int newValue)
            {
                List current = this;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new List(newValue);
            }
   


            public void addToEndSolution(int newValue)
            {
                if (this.next == null)
                {
                    this.next = new List(newValue);
                }
                else
                {
                    this.next.addToEndSolution(newValue);
                }
            }
            // Make method static; take input a list and check if it null; 
            public static bool isNull(List l)
            {
                return l == null;
            }

            public int Count()
            {
                int count = 0;

                List current = this;
                while (current != null)
                {
                    count++;
                    current = current.next;
                }
                return count;
            }

            public override bool Equals(object obj)
            {
                //If not a list
                if (!(obj is List))
                    return false;


                if (((List)obj).Count() != this.Count())
                    return false;
                else // same length
                {
                    //Deep check
                    List current = this;
                    List temp = (List)obj;
                    while (current != null)
                    {
                        if (temp.value != current.value)
                            return false;
                        current = current.next;
                        temp = temp.next; //Iterate                    
                    }
                }
                return true;
            }
            public List Clone()
            {
                List temp = new List();

                List current = this;
                if (current.Count() == 0)
                    return temp;
                else if (current.Count() == 1)
                {
                    temp.value = current.value;
                    return temp;
                }
                else
                {
                    temp.value = current.value;
                    current = current.next;
                    while (current != null)
                    {
                        temp.addToEndSolution(current.value);
                        current = current.next;

                    }
                }
                return temp;
            }

            public bool AreAllSame()
            {
                List current = this;
                if (current.Count() <= 1)
                {
                    return true;
                }
                else
                {
                    List other = new List();
                    while (current != null)
                    {
                        other = current.next; // since list is at least length 2, the next is guaranteed to not be null, 
                        while (other != null)
                        {
                            if (current.value != other.value)
                            {
                                return false;
                            }
                            other = other.next;
                        }

                        current = current.next;
                    }
                    return true;
                }
            }

            public bool IsInLast(int incomingVal)
            {
                List current = this;
                if (current.Count() == 1 && incomingVal == current.value)
                {
                    return true;
                }
                else
                {
                    List last = current;
                    while (current != null)
                    {
                        last = current;
                        current = current.next;
                    }
                    if (last.value == incomingVal)
                        return true;
                    return false;
                }
            }

            public bool isLengthOdd(){

                return this.Count() % 2 != 0;
            }

        }

        [PexMethod]
        public static void Check(List student_submission, List TA_submission)
        {
            PexAssert.IsTrue(student_submission.Equals(TA_submission));
        }


        //[PexMethod(TestEmissionFilter=PexTestEmissionFilter.All)]
        [PexMethod]
        public static void Check([PexAssumeNotNull]MetaProgram.List l, int x)
        {
            //TODO: write better PUT to take into account when both methods throw nullreference exception
            List l2 = l.Clone();
            
            l.addToEnd(x);
            l2.addToEndSolution(x);
            
            PexAssert.IsTrue(l.Equals(l2));
        
        }
        

    }
}

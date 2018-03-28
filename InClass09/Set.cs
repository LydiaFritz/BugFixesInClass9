using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;


        public Set( )
        {
            elements = new List<int>( );
        }

        public bool addElement( int val )
        {
            if (containsElement( val )) return false;
            else
            {
                elements.Add( val );
                return true;
            }
        }

        private bool containsElement( int val )
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[ i ])
                    return true;
                //Remove this...
                //automatically returned false if the first element isn't a match to val
                //else
                //    return false;
            }
            return false;
        }

        public override string ToString( )
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet( )
        {
            elements.Clear( );
        }

        public Set union( Set rhs )
        {
            //make a new Set
            Set result = new Set( );

            int a = 0;

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //not correct = this shouldn't change
                //this.addElement( rhs.elements[ i ] );
                result.addElement( rhs.elements[ i ] );

                
            }

            //now add elements from this set
            foreach(int i in elements)
            {
                result.addElement( i );
            }

            //should return result
            //return rhs;
            return result;
        }
    }
}

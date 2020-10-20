using System.Collections.Generic;

namespace Client.Misc
{
    // Static List Extension Class providing ToPrettyString extension method on any IEnumerable Collection
    public static class ListExtension
    {
        // return a string representation of the IEnumerable parameter data
        public static string ToPrettyString<T>(this IEnumerable<T> data)
        {   
            // provide a suitable loop to construct a string from the IEnumerable data
            // in format [ e1 e2 e3 ... ]
            var r = "[ ";
            foreach(var e in data)
            {
                r += $"{e} ";
            }

            r = r + "]";

            // return the newly constructed string
            return r;
        }
    }
}
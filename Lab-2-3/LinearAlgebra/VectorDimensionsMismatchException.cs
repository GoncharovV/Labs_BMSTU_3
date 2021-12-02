using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{
    public class VectorDimensionsMismatchException : Exception
    {
        public VectorDimensionsMismatchException() { }

        public VectorDimensionsMismatchException(string e) : base(e) { }


        public VectorDimensionsMismatchException(string message, Exception innerException)
            :base(message, innerException) { }
    }
}

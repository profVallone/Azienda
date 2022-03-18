using System;
using System.Runtime.Serialization;

namespace GestioneAzienda
{
    [Serializable]
    internal class FerieNonSufficienti : Exception
    {
        public FerieNonSufficienti()
        {
        }


        public FerieNonSufficienti(string message) : base(message)
        {
        }

        public FerieNonSufficienti(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FerieNonSufficienti(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Composite.Models
{
    public interface IGiftOperations
    {
        void Add(GiftBase gift);

        void Remove(GiftBase gift);
    }
}

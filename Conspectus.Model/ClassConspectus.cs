using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conspectus.Model
{
    public class ClassConspectus
    {
        public IEnumerable<MethodConspectus> Methods { get; set;}
        public IEnumerable<PropertyConspectus> Properties{ get; set;}
        public IEnumerable<FieldConspectus> Fields { get; set;}
        public IEnumerable<EventConspectus> Events{ get; set;}
    }

    public class MemberConspectus
    {
        public string Identifier { get; set; }
    }

    public class MethodConspectus : MemberConspectus
    {
    }

    public class PropertyConspectus : MemberConspectus
    {

    }

    public class FieldConspectus : MemberConspectus
    {

    }

    public class EventConspectus : MemberConspectus
    {

    }
}

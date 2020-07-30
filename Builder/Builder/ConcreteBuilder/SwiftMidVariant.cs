using System.Text;

namespace Builder.ConcreteBuilder
{
    sealed class SwiftMidVariant : SwiftLowEnd
    {
        public override string ToString()
        {
            StringBuilder properties = new StringBuilder();
            properties = CarProperties();
            properties.AppendLine("\n");
            properties.AppendLine("Printing additional properties of SwiftMidVariant:");
            properties.AppendLine("basically SwiftLowEnd car eh...enni paisal iste anni extra :p");

            return properties.ToString();
        }
    }
}

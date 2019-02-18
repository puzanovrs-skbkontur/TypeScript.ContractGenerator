using System.Collections.Generic;
using System.Text;

namespace SkbKontur.TypeScript.ContractGenerator.CodeDom
{
    public class FlowTypeInterfaceDefinition : FlowTypeType
    {
        public List<FlowTypeInterfaceFunctionMember> Members => members;

        public override string GenerateCode(ICodeGenerationContext context)
        {
            var result = new StringBuilder();
            result.AppendFormat("{{").Append(context.NewLine);
            foreach (var member in Members)
            {
                result.AppendWithTab(context.Tab, member.GenerateCode(context) + ";", context.NewLine).Append(context.NewLine);
            }
            result.Append("}");
            return result.ToString();
        }

        private readonly List<FlowTypeInterfaceFunctionMember> members = new List<FlowTypeInterfaceFunctionMember>();
    }
}
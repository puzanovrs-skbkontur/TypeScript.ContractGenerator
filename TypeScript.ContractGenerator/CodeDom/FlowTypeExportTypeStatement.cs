namespace SkbKontur.TypeScript.ContractGenerator.CodeDom
{
    public class FlowTypeExportTypeStatement : FlowTypeStatement
    {
        public FlowTypeTypeDeclaration Declaration { get; set; }

        public override string GenerateCode(ICodeGenerationContext context)
        {
            return string.Format("export {0}", Declaration.GenerateCode(context));
        }
    }
}
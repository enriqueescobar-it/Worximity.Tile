// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace NorthwindDemo.Configurations
{

    using NorthwindDemo.Entities;

    // VER_Versions
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class VerVersionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VerVersion>
    {
        public VerVersionConfiguration()
            : this("dbo")
        {
        }

        public VerVersionConfiguration(string schema)
        {
            Property(x => x.VerCKey).IsUnicode(false);
            Property(x => x.VerCValue).IsOptional().IsUnicode(false);
            Property(x => x.VerCAppStoreSite).IsOptional().IsUnicode(false);
        }
    }

}
// </auto-generated>

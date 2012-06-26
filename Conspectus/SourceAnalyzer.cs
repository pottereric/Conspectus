using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers.CSharp;

namespace Conspectus
{
    class SourceAnalyzer
    {
        protected string code;

        public SourceAnalyzer(string code)
        {
            this.code = code;
        }

        protected SyntaxList<MemberDeclarationSyntax> GetClassNodes()
        {
            // Have Roslyn Parse the file
            var tree = SyntaxTree.ParseCompilationUnit(this.code);
            CompilationUnitSyntax compilationUnit = (CompilationUnitSyntax)tree.Root;

            // TODO: don't hard code [0]
            // Get the Namespace node
            NamespaceDeclarationSyntax namespaceDeclaration = (NamespaceDeclarationSyntax)compilationUnit.Members[0];

            // Get the class node
            return namespaceDeclaration.Members;
        }
    }
}

﻿//
//   Copyright © 2010 Michael Feingold
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using Boo.Lang.Compiler.Ast;

namespace Hill30.Boo.ASTMapper.AST.Nodes
{
    public class MappedVariableDefinition : MappedNode
    {

        public MappedVariableDefinition(CompileResults results, ParameterDeclaration node)
            : base(results, node, node.Name.Length)
        {
        }

        public MappedVariableDefinition(CompileResults results, Local node)
            : base(results, node, node.Name.Length)
        {
        }

        public override MappedNodeType Type
        {
            get { return MappedNodeType.VariableDefinition; }
        }
    }
}

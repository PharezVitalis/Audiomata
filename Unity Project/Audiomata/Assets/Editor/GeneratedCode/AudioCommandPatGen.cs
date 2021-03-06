﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Assets.Editor.GeneratedCode
{
    using Audiomata.ComponentMapping;
    using UnityEngine.Audio;
    using UnityEngine;
    using Audiomata;
    using System.Linq;
    using System.Text;
    using System.Reflection;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class AudioCommandPatGen : AudioCommandPatGenBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
            this.Write(@"
namespace Audiomata.ComponentTrackers
{
//-------------------------------------------------------------------------------------------------------------------------------
//					THIS CODE IS AUTOMATICALLY GENERATED, DO NOT MODIFY
//-------------------------------------------------------------------------------------------------------------------------------
");
            
            #line 18 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"

 string typeName = TargetClass.propType.Name;
 string outClassName = typeName+"Commander";
 string enumName = typeName+"Members";
 
            
            #line default
            #line hidden
            this.Write("using UnityEngine;\r\nusing UnityEngine.Audio;\r\nusing System.Collections.Generic;\r\n" +
                    "using Audiomata;\r\n\r\n // Auto generated props, can use reflections but don\'t beca" +
                    "use it is REALLY slow\r\n#region EnumeratedProps\r\n public enum ");
            
            #line 30 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumName));
            
            #line default
            #line hidden
            this.Write("\r\n {\r\n\t");
            
            #line 32 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
 if(TargetClass.publicProps.Length>0){
            
            #line default
            #line hidden
            this.Write("          ");
            
            #line 33 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetClass.publicProps[TargetClass.publicProps.Length-1].Name));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 34 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"

        for (int j = 0; j<TargetClass.publicProps.Length-1;j++){
		
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 37 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(","+TargetClass.publicProps[j].Name));
            
            #line default
            #line hidden
            this.Write("\r\n\t");
            
            #line 38 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\r\n\t");
            
            #line 39 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
}
            
            #line default
            #line hidden
            this.Write(" }\r\n#endregion\r\n\r\n#region CommmandManager\r\n //Class to manage state of components" +
                    "\r\n public class ");
            
            #line 45 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outClassName));
            
            #line default
            #line hidden
            this.Write(" :IAudioCommandable\r\n {\r\n\tprivate LimitedStack<AudioCommand<");
            
            #line 47 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write("> > audioCommands;\r\n    public ");
            
            #line 48 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write(" Target{get;private set;}\r\n\r\n    public ");
            
            #line 50 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(outClassName));
            
            #line default
            #line hidden
            this.Write("()\r\n    {\r\n        audioCommands = new LimitedStack<AudioCommand<");
            
            #line 52 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write("> >();\r\n    }\r\n\r\n    public object DoCommand<T>(T value, int enumeratedProp)\r\n   " +
                    " {\r\n        AudioCommand<");
            
            #line 57 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write("> newCommand = CommandFactory(enumeratedProp);\r\n        newCommand.Do(value);\r\n  " +
                    "      audioCommands.Push(newCommand);\r\n        return newCommand;\r\n    }\r\n    \r\n" +
                    "    public object RegisterCommand(int enumeratedProp)\r\n    {\r\n        AudioComma" +
                    "nd<");
            
            #line 65 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write("> newCommand = CommandFactory(enumeratedProp);\r\n        audioCommands.Push(newCom" +
                    "mand);\r\n        return newCommand;\r\n    }\r\n\r\n    public void UndoCommand(object " +
                    "cmd)\r\n    {\r\n        AudioCommand<");
            
            #line 72 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write("> command = (AudioCommand<");
            
            #line 72 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write(">) cmd;\r\n        command.Undo();\r\n        audioCommands.Remove(command);\r\n    }\r\n" +
                    "\r\n\r\n    public void UndoLast()\r\n    {\r\n        if (audioCommands.Count<1)\r\n     " +
                    "   {\r\n            return;\r\n        }\r\n        \r\n        AudioCommand<");
            
            #line 85 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write("> popped = audioCommands.Pop();\r\n        popped.Undo();\r\n    }\r\n\r\n    public void" +
                    " UndoAll()\r\n    {\r\n        while (audioCommands.Count>0)\r\n        {\r\n           " +
                    " AudioCommand<");
            
            #line 93 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write("> popped = audioCommands.Pop();\r\n            popped.Undo();\r\n        }\r\n    }\r\n\r\n" +
                    "    public void ClearChangeHistory()\r\n    {\r\n        while (audioCommands.Count>" +
                    "0)\r\n        {\r\n            AudioCommand<");
            
            #line 102 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write("> popped = audioCommands.Pop();\r\n        }\r\n    }\r\n\r\n    private AudioCommand<");
            
            #line 106 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write(">CommandFactory(int enumeratedProp)\r\n    {\r\n        ");
            
            #line 108 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumName));
            
            #line default
            #line hidden
            this.Write(" commandPropTarget = ( ");
            
            #line 108 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumName));
            
            #line default
            #line hidden
            this.Write(" ) enumeratedProp;\r\n            AudioCommand<");
            
            #line 109 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write("> nextCommand;\r\n        switch(commandPropTarget){\r\n        ");
            
            #line 111 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
 
    for (int i =0; i<TargetClass.publicProps.Length; i++){
        PropertyInfo nextProp = TargetClass.publicProps[i];
        string nextPropName= nextProp.Name;
        string nexCommandName= GetCommandName(nextPropName);
            
            
            #line default
            #line hidden
            this.Write("            case ");
            
            #line 117 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumName));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 117 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextPropName));
            
            #line default
            #line hidden
            this.Write(":\r\n                nextCommand = new ");
            
            #line 118 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nexCommandName));
            
            #line default
            #line hidden
            this.Write("(Target);\r\n            return nextCommand;\r\n   ");
            
            #line 120 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
}

            
            #line default
            #line hidden
            this.Write("        default:\r\n            return null; \r\n      }\r\n    }\r\n }\r\n\r\n#endregion\r\n\r\n" +
                    "#region AutoGeneratedCommands\r\n\t");
            
            #line 130 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
for (int j = 0; j<TargetClass.publicProps.Length;j++){
	PropertyInfo nextProp = TargetClass.publicProps[j];
	string nextType;
        string nextPropName= nextProp.Name;
        bool shouldStep= false;
    
        switch(nextProp.PropertyType.Name)
        {
            case "Single":
                nextType = "float";
                shouldStep = true;
                break;
            case "Boolean":
                nextType = "bool";
                break;
            case "String":
                nextType = "string";
                break;
            case "Int32":
                nextType = "int";
                shouldStep = true;
                break;
            case "UInt32":
                nextType = "uint";
                shouldStep = true;
                break;
            case "Byte":
                nextType = "byte";
                break;
            case "SByte":
                nextType = "sbyte";
                break;
            case "Int16":
                nextType = "short";
                shouldStep = true;
                break;
            case "Int64":
                nextType = "long";
                shouldStep = true;
                break;
            case "UInt64":
                nextType = "ulong";
                shouldStep = true;
                break;
            case "IntPtr":
                case "UIntPtr":
                continue;
            case "Char":
                nextType = "char";
                break;
            default:
                nextType = nextProp.PropertyType.Name;
                break;
        }
	
        string nextPropClassName = GetCommandName(nextProp.Name);
	
            
            #line default
            #line hidden
            this.Write("\tpublic class ");
            
            #line 187 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextPropClassName));
            
            #line default
            #line hidden
            this.Write(" : AudioCommand< ");
            
            #line 187 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write(" >,IAudioCommand< ");
            
            #line 187 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextType));
            
            #line default
            #line hidden
            this.Write(" >\r\n{\r\n\r\n\tpublic ");
            
            #line 190 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextType));
            
            #line default
            #line hidden
            this.Write(" InitialValue { get; private set; }\r\n\tpublic ");
            
            #line 191 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextType));
            
            #line default
            #line hidden
            this.Write(" FinalValue { get; private set; }\r\n\tpublic CommandState CommandState {get;set;}\r\n" +
                    "    \r\n\r\n\tpublic ");
            
            #line 195 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextPropClassName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 195 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeName));
            
            #line default
            #line hidden
            this.Write(" target){\r\n\t\tTarget = target;\r\n\t}\r\n\r\n\tpublic override void Do(object newValue){\r\n" +
                    "\t\tInitialValue = Target.");
            
            #line 200 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextPropName));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\tFinalValue = (");
            
            #line 201 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextType));
            
            #line default
            #line hidden
            this.Write(") newValue;\r\n\t\tTarget.");
            
            #line 202 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextPropName));
            
            #line default
            #line hidden
            this.Write(" = FinalValue;\r\n\t}\r\n\r\n\tpublic void Do(");
            
            #line 205 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextType));
            
            #line default
            #line hidden
            this.Write(" newValue){\r\n\t\tInitialValue = Target.");
            
            #line 206 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextPropName));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\tFinalValue = newValue;\r\n\t\tTarget.");
            
            #line 208 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextPropName));
            
            #line default
            #line hidden
            this.Write(" = FinalValue;\r\n\t}\r\n\r\n\tpublic int TargetPropEnum()\r\n\t{\r\n\t\treturn (int)");
            
            #line 213 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(enumName));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 213 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextPropName));
            
            #line default
            #line hidden
            this.Write(";\r\n\t}\r\n\r\n\tpublic override void Undo(){\r\n\tTarget.");
            
            #line 217 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextPropName));
            
            #line default
            #line hidden
            this.Write(" = InitialValue;\r\n\t}\r\n    ");
            
            #line 219 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
 if (shouldStep){
            
            #line default
            #line hidden
            this.Write("\r\n    public override void Step(float t){\r\n            float diff = FinalValue - " +
                    "InitialValue;\r\n        ");
            
            #line 223 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
 if (nextType == "float"){
            
            #line default
            #line hidden
            this.Write("            Target.");
            
            #line 224 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextPropName));
            
            #line default
            #line hidden
            this.Write(" = InitialValue+(t*diff);\r\n    ");
            
            #line 225 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
} else{
            
            #line default
            #line hidden
            this.Write("            Target.");
            
            #line 226 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextPropName));
            
            #line default
            #line hidden
            this.Write(" =InitialValue+(");
            
            #line 226 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(nextType));
            
            #line default
            #line hidden
            this.Write(")(t*diff);  \r\n    ");
            
            #line 227 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
}
            
            #line default
            #line hidden
            this.Write("     }\r\n ");
            
            #line 229 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
 }
            
            #line default
            #line hidden
            this.Write("\r\n}\r\n   \r\n\t");
            
            #line 233 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
}//end Command creation for 
            
            #line default
            #line hidden
            this.Write("#endregion\r\n}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 238 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
    public string GetCommandName(string propName){
        char[] capsTmpArr= propName.ToCharArray();
        capsTmpArr[0] = char.ToUpper(capsTmpArr[0]);
        return  TargetClass.propType.Name+"Cmd"+(new string(capsTmpArr));
} 
        
        #line default
        #line hidden
        
        #line 243 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
 public AudioClassData TargetClass {get;set;} 
        
        #line default
        #line hidden
        
        #line 244 "C:\Users\Pharez\Documents\Repos\Audiomata\Unity Project\Audiomata\Assets\Editor\GeneratedCode\AudioCommandPatGen.tt"
 public string FileName {get{ return TargetClass.propType.Name+"Commander.cs";}} 
        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class AudioCommandPatGenBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}

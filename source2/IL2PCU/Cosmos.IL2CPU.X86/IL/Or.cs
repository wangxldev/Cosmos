using System;

namespace Cosmos.IL2CPU.X86.IL
{
	[Cosmos.IL2CPU.OpCode(ILOpCode.Code.Or)]
	public class Or: ILOpX86
	{
		public Or(ILOpCode aOpCode):base(aOpCode)
		{
		}

		#region Old code
		// using System;
		// 
		// using CPUx86 = Indy.IL2CPU.Assembler.X86;
		// 
		// namespace Indy.IL2CPU.IL.X86 {
		// 	[OpCode(OpCodeEnum.Or)]
		// 	public class Or: Op {
		// 		public Or(ILReader aReader, MethodInformation aMethodInfo)
		// 			: base(aReader, aMethodInfo) {
		// 		}
		// 		public override void DoAssemble() {
		//             new CPUx86.Pop { DestinationReg = CPUx86.Registers.EAX };
		//             new CPUx86.Pop { DestinationReg = CPUx86.Registers.EDX };
		//             new CPUx86.Or { DestinationReg = CPUx86.Registers.EAX, SourceReg = CPUx86.Registers.EDX };
		//             new CPUx86.Push { DestinationReg = CPUx86.Registers.EAX };
		// 			Assembler.StackContents.Pop();
		// 		}
		// 	}
		// }
		#endregion Old code
	}
}

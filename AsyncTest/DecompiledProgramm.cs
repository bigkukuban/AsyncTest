// Decompiled with JetBrains decompiler
// Type: AsyncTest.Program
// Assembly: AsyncTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DF77F245-8C53-42A7-BABC-8BEB52DCD6C6
// Assembly location: C:\Users\Dimitri\source\repos\AsyncTest\AsyncTest\bin\Debug\netcoreapp3.1\AsyncTest.dll
// Compiler-generated code is shown

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncTest
{
    internal class DecompiledProgram
    {
        public static void MainWork(string[] args)
        {
            new DecompiledProgram().WaitForMe();
        }

        //[AsyncStateMachine(typeof(DecompiledProgram.StateMachine_WaitForMe))]
        //[DebuggerStepThrough]
        public void WaitForMe()
        {
            DecompiledProgram.StateMachine_WaitForMe stateMachine = new DecompiledProgram.StateMachine_WaitForMe();
            stateMachine._parentProgram = this;
            stateMachine._taskBuilder = AsyncVoidMethodBuilder.Create();
            stateMachine._state_1 = -1;
            stateMachine._taskBuilder.Start<DecompiledProgram.StateMachine_WaitForMe>(ref stateMachine);
        }

        //[AsyncStateMachine(typeof(DecompiledProgram.StateMachineForCallMe))]
        //[DebuggerStepThrough]
        public Task<int> CallMe()
        {
            DecompiledProgram.StateMachineForCallMe stateMachine = new DecompiledProgram.StateMachineForCallMe();
            stateMachine._parentProgram = this;
            stateMachine._taskBuilder = AsyncTaskMethodBuilder<int>.Create();
            stateMachine._state_1 = -1;
            stateMachine._taskBuilder.Start<DecompiledProgram.StateMachineForCallMe>(ref stateMachine);
            return stateMachine._taskBuilder.Task;
        }

        public DecompiledProgram()
        {

        }

        //[CompilerGenerated]
        private sealed class StateMachine_WaitForMe : IAsyncStateMachine
        {
            public int _state_1;
            public AsyncVoidMethodBuilder _taskBuilder;
            public DecompiledProgram _parentProgram;
            private int result_1;
            private int result_2;
            private int state_3;
            private int state_4;
            private TaskAwaiter<int> _awaiterTask;

            public StateMachine_WaitForMe()
            {
            }

            void IAsyncStateMachine.MoveNext()
            {
                int num1 = this._state_1;
                try
                {
                    TaskAwaiter<int> awaiter1;
                    int num2;
                    TaskAwaiter<int> awaiter2;
                    switch (num1)
                    {
                        case 0:
                            awaiter1 = this._awaiterTask;
                            this._awaiterTask = new TaskAwaiter<int>();
                            this._state_1 = num2 = -1;
                            break;
                        case 1:
                            awaiter2 = this._awaiterTask;
                            this._awaiterTask = new TaskAwaiter<int>();
                            this._state_1 = num2 = -1;
                            goto label_8;
                        default:
                            awaiter1 = this._parentProgram.CallMe().GetAwaiter();
                            if (!awaiter1.IsCompleted)
                            {
                                this._state_1 = num2 = 0;
                                this._awaiterTask = awaiter1;
                                DecompiledProgram.StateMachine_WaitForMe stateMachine = this;
                                this._taskBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DecompiledProgram.StateMachine_WaitForMe>(ref awaiter1, ref stateMachine);
                                return;
                            }
                            break;
                    }
                    this.state_3 = awaiter1.GetResult();
                    this.result_1 = this.state_3;
                    awaiter2 = this._parentProgram.CallMe().GetAwaiter();
                    if (!awaiter2.IsCompleted)
                    {
                        this._state_1 = num2 = 1;
                        this._awaiterTask = awaiter2;
                        DecompiledProgram.StateMachine_WaitForMe stateMachine = this;
                        this._taskBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DecompiledProgram.StateMachine_WaitForMe>(ref awaiter2, ref stateMachine);
                        return;
                    }
                label_8:
                    this.state_4 = awaiter2.GetResult();
                    this.result_2 = this.state_4;
                    Console.WriteLine("Result1 : " + this.result_1.ToString() + " Result2: " + this.result_2.ToString() + "Ende !");
                }
                catch (Exception ex)
                {
                    this._state_1 = -2;
                    this._taskBuilder.SetException(ex);
                    return;
                }
                this._state_1 = -2;
                this._taskBuilder.SetResult();
            }

            //[DebuggerHidden]
            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

        //[CompilerGenerated]
        private sealed class StateMachineForCallMe : IAsyncStateMachine
        {
            public int _state_1;
            public AsyncTaskMethodBuilder<int> _taskBuilder;
            public DecompiledProgram _parentProgram;

            public StateMachineForCallMe()
            {

            }

            void IAsyncStateMachine.MoveNext()
            {
                int num = this._state_1;
                int result;
                try
                {
                    result = 1;
                }
                catch (Exception ex)
                {
                    this._state_1 = -2;
                    this._taskBuilder.SetException(ex);
                    return;
                }
                this._state_1 = -2;
                this._taskBuilder.SetResult(result);
            }

            //[DebuggerHidden]
            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }
    }
}

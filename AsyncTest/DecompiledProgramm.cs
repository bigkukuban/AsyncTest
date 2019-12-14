using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncTest
{
    internal class DecompiledProgramm
    {
        public static void MainWork(string[] args)
        {
            Console.WriteLine("Hello World!");
            new DecompiledProgramm().WaitForMe();
        }

//        [AsyncStateMachine(typeof(DecompiledProgramm.WaitForMeClass))]
//        [DebuggerStepThrough]
        public void WaitForMe()
        {
            DecompiledProgramm.WaitForMeClass stateMachine = new DecompiledProgramm.WaitForMeClass();
            stateMachine._this = this;
            stateMachine._methodBuilder = AsyncVoidMethodBuilder.Create();
            stateMachine._someState = -1;
            stateMachine._methodBuilder.Start<DecompiledProgramm.WaitForMeClass>(ref stateMachine);
        }

 //       [AsyncStateMachine(typeof(DecompiledProgramm.CallMeClass))]
 //       [DebuggerStepThrough]
        public Task<int> CallMe()
        {
            DecompiledProgramm.CallMeClass stateMachine = new DecompiledProgramm.CallMeClass();
            stateMachine._this = this;
            stateMachine._methodBuilder = AsyncTaskMethodBuilder<int>.Create();
            stateMachine._someState = -1;
            stateMachine._methodBuilder.Start<DecompiledProgramm.CallMeClass>(ref stateMachine);
            return stateMachine._methodBuilder.Task;
        }

        public DecompiledProgramm(): base()
        {
            
        }

      //  [CompilerGenerated]
        private sealed class WaitForMeClass : IAsyncStateMachine
        {
            public int _someState;
            public AsyncVoidMethodBuilder  _methodBuilder;
            public DecompiledProgramm _this;
            private int _awaiterResult;
            private int _awaiterTaskResult;
            private TaskAwaiter<int> _taskAwaiter;

            public WaitForMeClass(): base()
            {                
            }

            void IAsyncStateMachine.MoveNext()
            {
                int num1 = this._someState;
                try
                {
                    TaskAwaiter<int> awaiter;
                    int num2;
                    if (num1 != 0)
                    {
                        awaiter = this._this.CallMe().GetAwaiter();
                        if (!awaiter.IsCompleted)
                        {
                            this._someState = num2 = 0;
                            this._taskAwaiter = awaiter;
                            DecompiledProgramm.WaitForMeClass stateMachine = this;
                            this._methodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, DecompiledProgramm.WaitForMeClass>(ref awaiter, ref stateMachine);
                            return;
                        }
                    }
                    else
                    {
                        awaiter = this._taskAwaiter;
                        this._taskAwaiter = new TaskAwaiter<int>();
                        this._someState = num2 = -1;
                    }
                    this._awaiterTaskResult = awaiter.GetResult();
                    this._awaiterResult = this._awaiterTaskResult;
                    Console.WriteLine("Result : " + this._awaiterResult.ToString() + "Ende !");
                }
                catch (Exception ex)
                {
                    this._someState = -2;
                    this._methodBuilder.SetException(ex);
                    return;
                }
                this._someState = -2;
                this._methodBuilder.SetResult();
            }

       //     [DebuggerHidden]
            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }

   //     [CompilerGenerated]
        private sealed class CallMeClass : IAsyncStateMachine
        {
            public int _someState;
            public AsyncTaskMethodBuilder<int> _methodBuilder;
            public DecompiledProgramm _this;

            public CallMeClass()
            {                
            }

            void IAsyncStateMachine.MoveNext()
            {
                int num = this._someState;
                int result;
                try
                {
                    result = 1;
                }
                catch (Exception ex)
                {
                    this._someState = -2;
                    this._methodBuilder.SetException(ex);
                    return;
                }
                this._someState = -2;
                this._methodBuilder.SetResult(result);
            }

     //       [DebuggerHidden]
            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
            }
        }
    }
}

// <assemblyHash>f8e34dfb</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=15.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias ad;
extern alias mqttf;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("AD_dll", false)]
[assembly: global::System.Reflection.AssemblyCompany("")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("AD_dll")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
namespace Eindopdracht.Fakes
{
    /// <summary>Shim type of Eindopdracht.MyEnum`1</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(ad::Eindopdracht.MyEnum<>))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of MyEnum`1")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimMyEnum<T>
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<ad::Eindopdracht.MyEnum<T>>
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimMyEnum()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimMyEnum(ad::Eindopdracht.MyEnum<T> instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
            /// <summary>Sets the shim of MyEnum`1.get_Current()</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ad::Eindopdracht.MyEnum<T>, T> CurrentGet
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("get_Current", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(ad::Eindopdracht.MyEnum<T>), (object)null, "get_Current", typeof(T), new global::System.Type[]{});
                }
            }

            /// <summary>Sets the shim of MyEnum`1.System.Collections.IEnumerator.get_Current()</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ad::Eindopdracht.MyEnum<T>, object> CurrentSystemCollectionsIEnumeratorget
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("System.Collections.IEnumerator.get_Current", 36)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimNonPublicInstance
                        ((global::System.Delegate)value, typeof(ad::Eindopdracht.MyEnum<T>), (object)null, 
                         "System.Collections.IEnumerator.get_Current", typeof(object), new global::System.Type[]{});
                }
            }

            /// <summary>Sets the shim of MyEnum`1.MoveNext()</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ad::Eindopdracht.MyEnum<T>, bool> MoveNext
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("MoveNext", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(ad::Eindopdracht.MyEnum<T>), (object)null, "MoveNext", typeof(bool), new global::System.Type[]{});
                }
            }

            /// <summary>Sets the shim of MyEnum`1.Reset()</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<ad::Eindopdracht.MyEnum<T>> Reset
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("Reset", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(ad::Eindopdracht.MyEnum<T>), (object)null, "Reset", typeof(void), new global::System.Type[]{});
                }
            }
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::Eindopdracht.Fakes.ShimMyEnum<T>.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::Eindopdracht.Fakes.ShimMyEnum<T>.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(ad::Eindopdracht.MyEnum<T>), value);
            }
        }

        /// <summary>Binds the members of the interface to the shim.</summary>
        public global::Eindopdracht.Fakes.ShimMyEnum<T> Bind(global::System.Collections.IEnumerator target)
        {
            if (target == (global::System.Collections.IEnumerator)null)
              throw new global::System.ArgumentNullException("target");
            mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime
              .Bind<ad::Eindopdracht.MyEnum<T>, global::Eindopdracht.Fakes.ShimMyEnum<T>, global::System.Collections.IEnumerator>(this, target);
            return this;
        }

        /// <summary>Sets the shim of MyEnum`1.MyEnum`1(!0[] list)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<ad::Eindopdracht.MyEnum<T>, T[]> ConstructorT0Array
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(ad::Eindopdracht.MyEnum<T>), (object)null, 
                     ".ctor", typeof(void), new global::System.Type[]{typeof(T).MakeArrayType()});
            }
        }

        /// <summary>Sets the shim of MyEnum`1.get_Current()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<T> CurrentGet
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("get_Current", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<ad::Eindopdracht.MyEnum<T>, T>(value)), 
                     typeof(ad::Eindopdracht.MyEnum<T>), base.Instance, "get_Current", typeof(T), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of MyEnum`1.System.Collections.IEnumerator.get_Current()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<object> CurrentSystemCollectionsIEnumeratorget
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("System.Collections.IEnumerator.get_Current", 36)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimNonPublicInstance((global::System.Delegate)
                                                                                                         (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<ad::Eindopdracht.MyEnum<T>, object>(value)), 
                                                                                                       typeof(ad::Eindopdracht.MyEnum<T>), base.Instance, 
                                                                                                       "System.Collections.IEnumerator.get_Current", typeof(object), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of MyEnum`1.MoveNext()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<bool> MoveNext
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("MoveNext", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<ad::Eindopdracht.MyEnum<T>, bool>(value)), 
                                                                                                    typeof(ad::Eindopdracht.MyEnum<T>), base.Instance, "MoveNext", typeof(bool), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of MyEnum`1.Reset()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action Reset
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("Reset", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<ad::Eindopdracht.MyEnum<T>>(value)), 
                     typeof(ad::Eindopdracht.MyEnum<T>), base.Instance, "Reset", typeof(void), new global::System.Type[]{});
            }
        }
    }
}
namespace Eindopdracht.Fakes
{
    /// <summary>Shim type of Eindopdracht.TreeNode`1</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(ad::Eindopdracht.TreeNode<>))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of TreeNode`1")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimTreeNode<T>
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<ad::Eindopdracht.TreeNode<T>>
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimTreeNode()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimTreeNode(ad::Eindopdracht.TreeNode<T> instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
            /// <summary>Sets the shim of TreeNode`1.displayNode()</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<ad::Eindopdracht.TreeNode<T>> displayNode
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("displayNode", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(ad::Eindopdracht.TreeNode<T>), (object)null, 
                         "displayNode", typeof(void), new global::System.Type[]{});
                }
            }

            /// <summary>Sets the shim of TreeNode`1.getData()</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ad::Eindopdracht.TreeNode<T>, T> getData
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("getData", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(ad::Eindopdracht.TreeNode<T>), (object)null, "getData", typeof(T), new global::System.Type[]{});
                }
            }
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::Eindopdracht.Fakes.ShimTreeNode<T>.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::Eindopdracht.Fakes.ShimTreeNode<T>.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(ad::Eindopdracht.TreeNode<T>), value);
            }
        }

        /// <summary>Sets the shim of TreeNode`1.TreeNode`1()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<ad::Eindopdracht.TreeNode<T>> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(ad::Eindopdracht.TreeNode<T>), (object)null, ".ctor", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of TreeNode`1.displayNode()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action displayNode
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("displayNode", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<ad::Eindopdracht.TreeNode<T>>(value)), 
                     typeof(ad::Eindopdracht.TreeNode<T>), base.Instance, "displayNode", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of TreeNode`1.getData()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<T> getData
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("getData", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<ad::Eindopdracht.TreeNode<T>, T>(value)), 
                                                                                                    typeof(ad::Eindopdracht.TreeNode<T>), base.Instance, "getData", typeof(T), new global::System.Type[]{});
            }
        }
    }
}
namespace Eindopdracht.Fakes
{
    /// <summary>Shim type of Eindopdracht.pqItem`1</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(ad::Eindopdracht.pqItem<>))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of pqItem`1")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimpqItem<T>
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<ad::Eindopdracht.pqItem<T>>
        where T : global::System.IComparable
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimpqItem()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimpqItem(ad::Eindopdracht.pqItem<T> instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::Eindopdracht.Fakes.ShimpqItem<T>.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::Eindopdracht.Fakes.ShimpqItem<T>.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(ad::Eindopdracht.pqItem<T>), value);
            }
        }

        /// <summary>Sets the shim of pqItem`1.pqItem`1(!0 value, Int32 priority)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<ad::Eindopdracht.pqItem<T>, T, int> ConstructorT0Int32
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(ad::Eindopdracht.pqItem<T>), (object)null, 
                     ".ctor", typeof(void), new global::System.Type[]{typeof(T), typeof(int)});
            }
        }
    }
}
namespace Eindopdracht.Fakes
{
    /// <summary>Stub type of Eindopdracht.MyEnum`1</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(ad::Eindopdracht.MyEnum<>))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of MyEnum`1")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubMyEnum<T>
      : ad::Eindopdracht.MyEnum<T>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<ad::Eindopdracht.MyEnum<T>>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
    {
        /// <summary>Initializes a new instance</summary>
        public StubMyEnum(T[] list)
        : base(list)
        {
            this.InitializeStub();
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            get
            {
                return this.___callBase;
            }
            set
            {
                this.___callBase = value;
            }
        }

        /// <summary>Initializes a new instance of type StubMyEnum</summary>
        private void InitializeStub()
        {
        }

        /// <summary>Gets or sets the instance behavior.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.___instanceBehavior);
            }
            set
            {
                this.___instanceBehavior = value;
            }
        }

        /// <summary>Gets or sets the instance observer.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver InstanceObserver
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubObservers.GetValueOrCurrent(this.___instanceObserver);
            }
            set
            {
                this.___instanceObserver = value;
            }
        }

        private bool ___callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___instanceBehavior;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___instanceObserver;
    }
}
namespace Eindopdracht.Fakes
{
    /// <summary>Stub type of Eindopdracht.TreeNode`1</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(ad::Eindopdracht.TreeNode<>))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of TreeNode`1")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubTreeNode<T>
      : ad::Eindopdracht.TreeNode<T>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<ad::Eindopdracht.TreeNode<T>>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
    {
        /// <summary>Initializes a new instance</summary>
        public StubTreeNode()
        {
            this.InitializeStub();
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            get
            {
                return this.___callBase;
            }
            set
            {
                this.___callBase = value;
            }
        }

        /// <summary>Initializes a new instance of type StubTreeNode</summary>
        private void InitializeStub()
        {
        }

        /// <summary>Gets or sets the instance behavior.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.___instanceBehavior);
            }
            set
            {
                this.___instanceBehavior = value;
            }
        }

        /// <summary>Gets or sets the instance observer.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver InstanceObserver
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubObservers.GetValueOrCurrent(this.___instanceObserver);
            }
            set
            {
                this.___instanceObserver = value;
            }
        }

        private bool ___callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___instanceBehavior;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___instanceObserver;
    }
}
namespace Eindopdracht.Fakes
{
    /// <summary>Stub type of Eindopdracht.pqItem`1</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(ad::Eindopdracht.pqItem<>))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of pqItem`1")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubpqItem<T>
      : ad::Eindopdracht.pqItem<T>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<ad::Eindopdracht.pqItem<T>>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
        where T : global::System.IComparable
    {
        /// <summary>Initializes a new instance</summary>
        public StubpqItem(T value, int priority)
        : base(value, priority)
        {
            this.InitializeStub();
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            get
            {
                return this.___callBase;
            }
            set
            {
                this.___callBase = value;
            }
        }

        /// <summary>Initializes a new instance of type StubpqItem</summary>
        private void InitializeStub()
        {
        }

        /// <summary>Gets or sets the instance behavior.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.___instanceBehavior);
            }
            set
            {
                this.___instanceBehavior = value;
            }
        }

        /// <summary>Gets or sets the instance observer.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver InstanceObserver
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubObservers.GetValueOrCurrent(this.___instanceObserver);
            }
            set
            {
                this.___instanceObserver = value;
            }
        }

        private bool ___callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___instanceBehavior;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___instanceObserver;
    }
}

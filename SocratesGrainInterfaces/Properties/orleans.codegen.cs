//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace SocratesGrainInterfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using Orleans.Runtime;
    using System.Collections;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class AttendeeFactory
    {
        

                        public static SocratesGrainInterfaces.IAttendee GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SocratesGrainInterfaces.IAttendee), 828979277, primaryKey));
                        }

                        public static SocratesGrainInterfaces.IAttendee GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SocratesGrainInterfaces.IAttendee), 828979277, primaryKey, grainClassNamePrefix));
                        }

                        public static SocratesGrainInterfaces.IAttendee GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SocratesGrainInterfaces.IAttendee), 828979277, primaryKey));
                        }

                        public static SocratesGrainInterfaces.IAttendee GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SocratesGrainInterfaces.IAttendee), 828979277, primaryKey, grainClassNamePrefix));
                        }

            public static SocratesGrainInterfaces.IAttendee Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return AttendeeReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("SocratesGrainInterfaces.SocratesGrainInterfaces.IAttendee")]
        internal class AttendeeReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, SocratesGrainInterfaces.IAttendee
        {
            

            public static SocratesGrainInterfaces.IAttendee Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (SocratesGrainInterfaces.IAttendee) global::Orleans.Runtime.GrainReference.CastInternal(typeof(SocratesGrainInterfaces.IAttendee), (global::Orleans.Runtime.GrainReference gr) => { return new AttendeeReference(gr);}, grainRef, 828979277);
            }
            
            protected internal AttendeeReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal AttendeeReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 828979277;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "SocratesGrainInterfaces.SocratesGrainInterfaces.IAttendee";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                AttendeeReference input = ((AttendeeReference)(original));
                return ((AttendeeReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                AttendeeReference input = ((AttendeeReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return AttendeeReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return AttendeeMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task SocratesGrainInterfaces.IAttendee.RegisterForSession(int @sessionId)
            {

                return base.InvokeMethodAsync<object>(1132774419, new object[] {@sessionId} );
            }
            
            System.Threading.Tasks.Task<string> SocratesGrainInterfaces.IAttendee.Name()
            {

                return base.InvokeMethodAsync<System.String>(-67873697, null );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("SocratesGrainInterfaces.SocratesGrainInterfaces.IAttendee", 828979277)]
    internal class AttendeeMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 828979277;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 828979277:  // IAttendee
                        switch (methodId)
                        {
                            case 1132774419: 
                                return ((IAttendee)grain).RegisterForSession((Int32)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case -67873697: 
                                return ((IAttendee)grain).Name().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 828979277:  // IAttendee
                    switch (methodId)
                    {
                        case 1132774419:
                            return "RegisterForSession";
                    case -67873697:
                            return "Name";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class SessionFactory
    {
        

                        public static SocratesGrainInterfaces.ISession GetGrain(long primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SocratesGrainInterfaces.ISession), -1148681821, primaryKey));
                        }

                        public static SocratesGrainInterfaces.ISession GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SocratesGrainInterfaces.ISession), -1148681821, primaryKey, grainClassNamePrefix));
                        }

                        public static SocratesGrainInterfaces.ISession GetGrain(System.Guid primaryKey)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SocratesGrainInterfaces.ISession), -1148681821, primaryKey));
                        }

                        public static SocratesGrainInterfaces.ISession GetGrain(System.Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeGrainReferenceInternal(typeof(SocratesGrainInterfaces.ISession), -1148681821, primaryKey, grainClassNamePrefix));
                        }

            public static SocratesGrainInterfaces.ISession Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return SessionReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("SocratesGrainInterfaces.SocratesGrainInterfaces.ISession")]
        internal class SessionReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, SocratesGrainInterfaces.ISession
        {
            

            public static SocratesGrainInterfaces.ISession Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (SocratesGrainInterfaces.ISession) global::Orleans.Runtime.GrainReference.CastInternal(typeof(SocratesGrainInterfaces.ISession), (global::Orleans.Runtime.GrainReference gr) => { return new SessionReference(gr);}, grainRef, -1148681821);
            }
            
            protected internal SessionReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal SessionReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -1148681821;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "SocratesGrainInterfaces.SocratesGrainInterfaces.ISession";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                SessionReference input = ((SessionReference)(original));
                return ((SessionReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                SessionReference input = ((SessionReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return SessionReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return SessionMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task SocratesGrainInterfaces.ISession.AddAttendee(SocratesGrainInterfaces.IAttendee @attendee)
            {

                return base.InvokeMethodAsync<object>(1417540964, new object[] {@attendee is global::Orleans.Grain ? @attendee.AsReference<SocratesGrainInterfaces.IAttendee>() : @attendee} );
            }
            
            System.Threading.Tasks.Task<System.Collections.Generic.IList<SocratesGrainInterfaces.IAttendee>> SocratesGrainInterfaces.ISession.Attendees()
            {

                return base.InvokeMethodAsync<System.Collections.Generic.IList<SocratesGrainInterfaces.IAttendee>>(1662102827, null );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("SocratesGrainInterfaces.SocratesGrainInterfaces.ISession", -1148681821)]
    internal class SessionMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -1148681821;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1148681821:  // ISession
                        switch (methodId)
                        {
                            case 1417540964: 
                                return ((ISession)grain).AddAttendee((IAttendee)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case 1662102827: 
                                return ((ISession)grain).Attendees().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -1148681821:  // ISession
                    switch (methodId)
                    {
                        case 1417540964:
                            return "AddAttendee";
                    case 1662102827:
                            return "Attendees";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif

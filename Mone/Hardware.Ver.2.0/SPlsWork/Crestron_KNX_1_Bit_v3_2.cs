using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using CrestronKNXLibrary.Communication;
using CrestronKNXLibrary.Routing;
using CrestronKNXLibrary.General;
using CrestronKNXLibrary.Data_Types;

namespace UserModule_CRESTRON_KNX_1_BIT_V3_2
{
    public class UserModuleClass_CRESTRON_KNX_1_BIT_V3_2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INITIALIZE;
        Crestron.Logos.SplusObjects.DigitalInput POLL_VALUE;
        Crestron.Logos.SplusObjects.DigitalInput SET_ON;
        Crestron.Logos.SplusObjects.DigitalInput SET_OFF;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZATIONISCOMPLETE;
        Crestron.Logos.SplusObjects.DigitalOutput ON_FEEDBACK;
        Crestron.Logos.SplusObjects.DigitalOutput OFF_FEEDBACK;
        UShortParameter IPGATEWAYID;
        StringParameter SPADDRESS;
        CrestronKNXLibrary.Data_Types.KNXOneBitSimplSharpComponent SIMPLSHARPCOMPONENT;
        object INITIALIZE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 80;
                SIMPLSHARPCOMPONENT . InitializeSettings ( (int)( IPGATEWAYID  .Value ), GetSymbolReferenceName() .ToString(), SPADDRESS  .ToString()) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object POLL_VALUE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 85;
            SIMPLSHARPCOMPONENT . PollValue ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SET_ON_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 90;
        SIMPLSHARPCOMPONENT . ChangeValue ( (int)( 1 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_OFF_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 96;
        SIMPLSHARPCOMPONENT . ChangeValue ( (int)( 0 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void UPDATEONEBITVALUECALLBACK ( ushort VALUE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 106;
        if ( Functions.TestForTrue  ( ( VALUE)  ) ) 
            { 
            __context__.SourceCodeLine = 108;
            OFF_FEEDBACK  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 109;
            ON_FEEDBACK  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 113;
            ON_FEEDBACK  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 114;
            OFF_FEEDBACK  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void INITIALIZATIONISCOMPLETECALLBACK ( ushort TEMPSTATE ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 121;
        INITIALIZATIONISCOMPLETE  .Value = (ushort) ( TEMPSTATE ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public void BASICINITIALIZATIONISCOMPLETEHANDLER ( ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
        
        __context__.SourceCodeLine = 128;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , INITIALIZATIONISCOMPLETE , INITIALIZATIONISCOMPLETECALLBACK ) 
        SIMPLSHARPCOMPONENT .initializationIsComplete  = INITIALIZATIONISCOMPLETECALLBACK; ; 
        __context__.SourceCodeLine = 129;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , UPDATEONEBITVALUE , UPDATEONEBITVALUECALLBACK ) 
        SIMPLSHARPCOMPONENT .UpdateOneBitValue  = UPDATEONEBITVALUECALLBACK; ; 
        __context__.SourceCodeLine = 133;
        SIMPLSHARPCOMPONENT . BeginInitialization ( ) ; 
        
        
    }
    finally { ObjectFinallyHandler(); }
    }
    
public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 146;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 147;
        // RegisterDelegate( SIMPLSHARPCOMPONENT , BASICINITIALIZATIONISCOMPLETE , BASICINITIALIZATIONISCOMPLETEHANDLER ) 
        SIMPLSHARPCOMPONENT .basicInitializationIsComplete  = BASICINITIALIZATIONISCOMPLETEHANDLER; ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    INITIALIZE = new Crestron.Logos.SplusObjects.DigitalInput( INITIALIZE__DigitalInput__, this );
    m_DigitalInputList.Add( INITIALIZE__DigitalInput__, INITIALIZE );
    
    POLL_VALUE = new Crestron.Logos.SplusObjects.DigitalInput( POLL_VALUE__DigitalInput__, this );
    m_DigitalInputList.Add( POLL_VALUE__DigitalInput__, POLL_VALUE );
    
    SET_ON = new Crestron.Logos.SplusObjects.DigitalInput( SET_ON__DigitalInput__, this );
    m_DigitalInputList.Add( SET_ON__DigitalInput__, SET_ON );
    
    SET_OFF = new Crestron.Logos.SplusObjects.DigitalInput( SET_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( SET_OFF__DigitalInput__, SET_OFF );
    
    INITIALIZATIONISCOMPLETE = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZATIONISCOMPLETE__DigitalOutput__, this );
    m_DigitalOutputList.Add( INITIALIZATIONISCOMPLETE__DigitalOutput__, INITIALIZATIONISCOMPLETE );
    
    ON_FEEDBACK = new Crestron.Logos.SplusObjects.DigitalOutput( ON_FEEDBACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( ON_FEEDBACK__DigitalOutput__, ON_FEEDBACK );
    
    OFF_FEEDBACK = new Crestron.Logos.SplusObjects.DigitalOutput( OFF_FEEDBACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( OFF_FEEDBACK__DigitalOutput__, OFF_FEEDBACK );
    
    IPGATEWAYID = new UShortParameter( IPGATEWAYID__Parameter__, this );
    m_ParameterList.Add( IPGATEWAYID__Parameter__, IPGATEWAYID );
    
    SPADDRESS = new StringParameter( SPADDRESS__Parameter__, this );
    m_ParameterList.Add( SPADDRESS__Parameter__, SPADDRESS );
    
    
    INITIALIZE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INITIALIZE_OnPush_0, false ) );
    POLL_VALUE.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_VALUE_OnPush_1, false ) );
    SET_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_ON_OnPush_2, false ) );
    SET_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_OFF_OnPush_3, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    SIMPLSHARPCOMPONENT  = new CrestronKNXLibrary.Data_Types.KNXOneBitSimplSharpComponent();
    
    
}

public UserModuleClass_CRESTRON_KNX_1_BIT_V3_2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INITIALIZE__DigitalInput__ = 0;
const uint POLL_VALUE__DigitalInput__ = 1;
const uint SET_ON__DigitalInput__ = 2;
const uint SET_OFF__DigitalInput__ = 3;
const uint INITIALIZATIONISCOMPLETE__DigitalOutput__ = 0;
const uint ON_FEEDBACK__DigitalOutput__ = 1;
const uint OFF_FEEDBACK__DigitalOutput__ = 2;
const uint IPGATEWAYID__Parameter__ = 10;
const uint SPADDRESS__Parameter__ = 11;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}

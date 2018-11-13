namespace CrestronKNXLibrary.Communication;
        // class declarations
         class KNXCommunicationComponent;
         class CIKNX2Communication;
         class CIKNXCommunication;
         class CGEIBIPCommunication;
     class KNXCommunicationComponent 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace CrestronKNXLibrary.Routing;
        // class declarations
         class RouterComponent;
         class KNXRouterSimplSharpComponent;
         class KNXRouter;
           class DelegateNoParameters;
           class DelegateUshort;
     class RouterComponent 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION PollAll ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class KNXRouterSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateNoParameters ( );
        delegate FUNCTION DelegateUshort ( INTEGER value );

        // class events

        // class functions
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , SIGNED_LONG_INTEGER type , STRING version , STRING address , SIGNED_LONG_INTEGER port );
        FUNCTION BeginInitialization ();
        FUNCTION ChangeDebugMode ( SIGNED_LONG_INTEGER value );
        FUNCTION ChangeSendDelay ( SIGNED_LONG_INTEGER paramValue );
        FUNCTION ChangeSendRetries ( SIGNED_LONG_INTEGER paramValue );
        FUNCTION ChangeSendEmailOnFailureState ( SIGNED_LONG_INTEGER paramValue );
        FUNCTION ChangeFromEmailAddress ( STRING paramAddress );
        FUNCTION ChangeToEmailAddress ( STRING paramAddress );
        FUNCTION ChangeMailServerAddress ( STRING paramAddress );
        FUNCTION ChangeMailServerPort ( SIGNED_LONG_INTEGER paramValue );
        FUNCTION ChangeMailServerSecureConnection ( SIGNED_LONG_INTEGER paramValue );
        FUNCTION ChangeUserLogonName ( STRING paramAddress );
        FUNCTION ChangeUserLogonPassword ( STRING paramAddress );
        FUNCTION PollAllAddresses ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
        DelegateProperty DelegateUshort initializationIsComplete;
        DelegateProperty DelegateUshort UpdateConnectionStatus;
    };

     class KNXRouter 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION PollAll ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace CrestronKNXLibrary.General;
        // class declarations
         class KNXRouterType;
         class KNXSystem;
    static class KNXRouterType // enum
    {
        static SIGNED_LONG_INTEGER CGEIBIP;
        static SIGNED_LONG_INTEGER CIKNX;
        static SIGNED_LONG_INTEGER CIKNX2;
    };

    static class KNXSystem 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

namespace CrestronKNXLibrary.Data_Types;
        // class declarations
         class DataTypeComponent;
         class KNXOneBitSimplSharpComponent;
         class KNXFourBitSimplSharpComponent;
         class KNXTwoBitSimplSharpComponent;
         class KNXSixByteSimplSharpComponent;
         class KNXTwoByteSimplSharpComponent;
         class KNXFourBytesSimplSharpComponent;
         class KNXDateSimplSharpComponent;
         class KNXTimeSimplSharpComponent;
         class KNXThreeByteSimplSharpComponent;
         class KNXFourteenByteSimplSharpComponent;
         class KNXOneByteSimplSharpComponent;
           class DelegateInteger;
           class DelegateString;
           class DelegateShort;
     class DataTypeComponent 
    {
        // class delegates
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };

     class KNXOneBitSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateUshort ( INTEGER value );
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION BeginInitialization ();
        FUNCTION ChangeValue ( SIGNED_LONG_INTEGER value );
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateUshort initializationIsComplete;
        DelegateProperty DelegateUshort UpdateOneBitValue;
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };

     class KNXFourBitSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateInteger ( SIGNED_LONG_INTEGER value );
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION BeginInitialization ();
        FUNCTION DimUp ();
        FUNCTION DimDown ();
        FUNCTION StopDimming ();
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateInteger initializationIsComplete;
        DelegateProperty DelegateInteger UpdateFourBitValue;
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };

     class KNXTwoBitSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateUshort ( INTEGER value );
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION BeginInitialization ();
        FUNCTION SetControl ( SIGNED_LONG_INTEGER temp );
        FUNCTION SetValue ( SIGNED_LONG_INTEGER temp );
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateUshort initializationIsComplete;
        DelegateProperty DelegateUshort UpdateControlValue;
        DelegateProperty DelegateUshort UpdateValue;
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };

     class KNXSixByteSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateUshort ( INTEGER value );
        delegate FUNCTION DelegateString ( SIMPLSHARPSTRING value );
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION BeginInitialization ();
        FUNCTION ChangeValue ( LONG_INTEGER lowBytes , LONG_INTEGER midBytes , LONG_INTEGER highBytes );
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateUshort initializationIsComplete;
        DelegateProperty DelegateUshort UpdateSixByteValueLowBytes;
        DelegateProperty DelegateUshort UpdateSixByteValueMidBytes;
        DelegateProperty DelegateUshort UpdateSixByteValueHighBytes;
        DelegateProperty DelegateString UpdateSixBytesUnsignedValue;
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };

     class KNXTwoByteSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateUshort ( INTEGER value );
        delegate FUNCTION DelegateShort ( SIGNED_INTEGER value );
        delegate FUNCTION DelegateString ( SIMPLSHARPSTRING value );
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION BeginInitialization ();
        FUNCTION ChangeValue ( SIGNED_LONG_INTEGER value );
        FUNCTION ChangeEIS5Value ( SIGNED_LONG_INTEGER sign , SIGNED_LONG_INTEGER value );
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateUshort initializationIsComplete;
        DelegateProperty DelegateUshort UpdateTwoByteValue;
        DelegateProperty DelegateUshort UpdateTwoByteEIS5MantissaValue;
        DelegateProperty DelegateUshort UpdateTwoByteEIS5ExponentValue;
        DelegateProperty DelegateUshort UpdateTwoByteEIS5SignValue;
        DelegateProperty DelegateShort UpdateTwoByteEIS5AbsoluteValue;
        DelegateProperty DelegateString UpdateTwoByteEIS5AbsoluteValueText;
        DelegateProperty DelegateString UpdateTwoByteEIS5DecimalValueText;
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };

     class KNXFourBytesSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateUshort ( INTEGER value );
        delegate FUNCTION DelegateString ( SIMPLSHARPSTRING value );
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION BeginInitialization ();
        FUNCTION ChangeValue ( LONG_INTEGER lowBytes , LONG_INTEGER highBytes );
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateUshort initializationIsComplete;
        DelegateProperty DelegateUshort UpdateFourByteValueLowBytes;
        DelegateProperty DelegateUshort UpdateFourByteValueHighBytes;
        DelegateProperty DelegateString UpdateFourBytesUnsignedValue;
        DelegateProperty DelegateString UpdateFourBytesSignedValue;
        DelegateProperty DelegateString UpdateFourBytesFPValue;
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };

     class KNXDateSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateUshort ( INTEGER value );
        delegate FUNCTION DelegateString ( SIMPLSHARPSTRING value );
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION BeginInitialization ();
        FUNCTION SendSystemDate ();
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateUshort initializationIsComplete;
        DelegateProperty DelegateUshort UpdateDayValue;
        DelegateProperty DelegateUshort UpdateMonthValue;
        DelegateProperty DelegateUshort UpdateYearValue;
        DelegateProperty DelegateString UpdateDateValueText;
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };

     class KNXTimeSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateUshort ( INTEGER value );
        delegate FUNCTION DelegateString ( SIMPLSHARPSTRING value );
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION BeginInitialization ();
        FUNCTION SendSystemTime ();
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateUshort initializationIsComplete;
        DelegateProperty DelegateUshort UpdateDayValue;
        DelegateProperty DelegateUshort UpdateHoursValue;
        DelegateProperty DelegateUshort UpdateMinutesValue;
        DelegateProperty DelegateUshort UpdateSecondsValue;
        DelegateProperty DelegateString UpdateTimeValueText;
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };

     class KNXThreeByteSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateUshort ( INTEGER value );
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION BeginInitialization ();
        FUNCTION SendThreeByteValue ( SIGNED_LONG_INTEGER paramByte1 , SIGNED_LONG_INTEGER paramByte2 , SIGNED_LONG_INTEGER paramByte3 );
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateUshort initializationIsComplete;
        DelegateProperty DelegateUshort UpdateByte1Value;
        DelegateProperty DelegateUshort UpdateByte2Value;
        DelegateProperty DelegateUshort UpdateByte3Value;
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };

     class KNXFourteenByteSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateUshort ( INTEGER value );
        delegate FUNCTION DelegateString ( SIMPLSHARPSTRING value );
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION BeginInitialization ();
        FUNCTION ChangeValue ( STRING value );
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateUshort initializationIsComplete;
        DelegateProperty DelegateString UpdateFourteenByteValue;
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };

     class KNXOneByteSimplSharpComponent 
    {
        // class delegates
        delegate FUNCTION DelegateUshort ( INTEGER value );
        delegate FUNCTION DelegateNoParameters ( );

        // class events

        // class functions
        FUNCTION BeginInitialization ();
        FUNCTION ChangeValue ( SIGNED_LONG_INTEGER value );
        FUNCTION InitializeSettings ( SIGNED_LONG_INTEGER id , STRING version , STRING address );
        FUNCTION KNXRouterInitializationCompleteEventHandler ( SIGNED_LONG_INTEGER id , RouterComponent router );
        FUNCTION PollValue ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty DelegateUshort initializationIsComplete;
        DelegateProperty DelegateUshort UpdateOneByteValue;
        DelegateProperty DelegateNoParameters basicInitializationIsComplete;
    };


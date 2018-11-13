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

namespace UserModule_PRESSET
{
    public class UserModuleClass_PRESSET : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput STORE;
        Crestron.Logos.SplusObjects.DigitalInput RECALL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> PRESSET;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> INPUT_D;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> INPUT_A;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> OUT_D_ON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> OUT_D_OFF;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> OUT_A;
        UShortParameter ID_NUM;
        ushort [] IARRAY;
        ushort [] IARRAY2;
        private void STOREFUNC (  SplusExecutionContext __context__, ushort NUMBER_PRESSET ) 
            { 
            ushort NFILEHANDLE = 0;
            ushort IERRORCODE = 0;
            ushort X = 0;
            ushort Y = 0;
            
            CrestronString ID_S;
            ID_S  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            
            __context__.SourceCodeLine = 132;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)150; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 134;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( X < 31 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 136;
                    IARRAY [ X] = (ushort) ( INPUT_A[ X ] .UshortValue ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 140;
                    Y = (ushort) ( (X - 30) ) ; 
                    __context__.SourceCodeLine = 141;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INPUT_D[ Y ] .Value > 0 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 142;
                        IARRAY [ X] = (ushort) ( 1 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 144;
                        IARRAY [ X] = (ushort) ( 0 ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 132;
                } 
            
            __context__.SourceCodeLine = 147;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)NUMBER_PRESSET);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 151;
                        ID_S  .UpdateValue ( "\\CF0\\Presset1_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 152;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 153;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileDelete( ID_S ) != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 154;
                            Print( "Error deleting file\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 155;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) ((1 | 256) | 32768) ) ) ; 
                        __context__.SourceCodeLine = 156;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 158;
                            IERRORCODE = (ushort) ( WriteIntegerArray( (short)( NFILEHANDLE ) , IARRAY ) ) ; 
                            __context__.SourceCodeLine = 159;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 160;
                                Print( "Array written to file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 162;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 163;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 165;
                                Print( "Error closing file\r\n") ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 168;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 172;
                        ID_S  .UpdateValue ( "\\CF0\\Presset2_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 173;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 174;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileDelete( ID_S ) != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 175;
                            Print( "Error deleting file\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 176;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) ((1 | 256) | 32768) ) ) ; 
                        __context__.SourceCodeLine = 177;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 179;
                            IERRORCODE = (ushort) ( WriteIntegerArray( (short)( NFILEHANDLE ) , IARRAY ) ) ; 
                            __context__.SourceCodeLine = 180;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 181;
                                Print( "Array written to file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 183;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 184;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 186;
                                Print( "Error closing file\r\n") ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 189;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 193;
                        ID_S  .UpdateValue ( "\\CF0\\Presset3_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 194;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 195;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileDelete( ID_S ) != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 196;
                            Print( "Error deleting file\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 197;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) ((1 | 256) | 32768) ) ) ; 
                        __context__.SourceCodeLine = 198;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 200;
                            IERRORCODE = (ushort) ( WriteIntegerArray( (short)( NFILEHANDLE ) , IARRAY ) ) ; 
                            __context__.SourceCodeLine = 201;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 202;
                                Print( "Array written to file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 204;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 205;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 207;
                                Print( "Error closing file\r\n") ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 210;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 214;
                        ID_S  .UpdateValue ( "\\CF0\\Presset4_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 215;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 216;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileDelete( ID_S ) != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 217;
                            Print( "Error deleting file\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 218;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) ((1 | 256) | 32768) ) ) ; 
                        __context__.SourceCodeLine = 219;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 221;
                            IERRORCODE = (ushort) ( WriteIntegerArray( (short)( NFILEHANDLE ) , IARRAY ) ) ; 
                            __context__.SourceCodeLine = 222;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 223;
                                Print( "Array written to file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 225;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 226;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 228;
                                Print( "Error closing file\r\n") ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 231;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 235;
                        ID_S  .UpdateValue ( "\\CF0\\Presset5_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 236;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 237;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileDelete( ID_S ) != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 238;
                            Print( "Error deleting file\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 239;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) ((1 | 256) | 32768) ) ) ; 
                        __context__.SourceCodeLine = 240;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 242;
                            IERRORCODE = (ushort) ( WriteIntegerArray( (short)( NFILEHANDLE ) , IARRAY ) ) ; 
                            __context__.SourceCodeLine = 243;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 244;
                                Print( "Array written to file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 246;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 247;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 249;
                                Print( "Error closing file\r\n") ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 252;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 256;
                        ID_S  .UpdateValue ( "\\CF0\\Presset6_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 257;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 258;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileDelete( ID_S ) != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 259;
                            Print( "Error deleting file\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 260;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) ((1 | 256) | 32768) ) ) ; 
                        __context__.SourceCodeLine = 261;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 263;
                            IERRORCODE = (ushort) ( WriteIntegerArray( (short)( NFILEHANDLE ) , IARRAY ) ) ; 
                            __context__.SourceCodeLine = 264;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 265;
                                Print( "Array written to file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 267;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 268;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 270;
                                Print( "Error closing file\r\n") ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 273;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 277;
                        ID_S  .UpdateValue ( "\\CF0\\Presset7_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 278;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 279;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileDelete( ID_S ) != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 280;
                            Print( "Error deleting file\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 281;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) ((1 | 256) | 32768) ) ) ; 
                        __context__.SourceCodeLine = 282;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 284;
                            IERRORCODE = (ushort) ( WriteIntegerArray( (short)( NFILEHANDLE ) , IARRAY ) ) ; 
                            __context__.SourceCodeLine = 285;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 286;
                                Print( "Array written to file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 288;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 289;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 291;
                                Print( "Error closing file\r\n") ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 294;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 298;
                        ID_S  .UpdateValue ( "\\CF0\\Presset8_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 299;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 300;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileDelete( ID_S ) != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 301;
                            Print( "Error deleting file\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 302;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) ((1 | 256) | 32768) ) ) ; 
                        __context__.SourceCodeLine = 303;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 305;
                            IERRORCODE = (ushort) ( WriteIntegerArray( (short)( NFILEHANDLE ) , IARRAY ) ) ; 
                            __context__.SourceCodeLine = 306;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 307;
                                Print( "Array written to file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 309;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 310;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 312;
                                Print( "Error closing file\r\n") ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 315;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 9) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 319;
                        ID_S  .UpdateValue ( "\\CF0\\Presset9_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 320;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 321;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileDelete( ID_S ) != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 322;
                            Print( "Error deleting file\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 323;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) ((1 | 256) | 32768) ) ) ; 
                        __context__.SourceCodeLine = 324;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 326;
                            IERRORCODE = (ushort) ( WriteIntegerArray( (short)( NFILEHANDLE ) , IARRAY ) ) ; 
                            __context__.SourceCodeLine = 327;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 328;
                                Print( "Array written to file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 330;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 331;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 333;
                                Print( "Error closing file\r\n") ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 336;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 340;
                        ID_S  .UpdateValue ( "\\CF0\\Presset10_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 341;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 342;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileDelete( ID_S ) != 0))  ) ) 
                            {
                            __context__.SourceCodeLine = 343;
                            Print( "Error deleting file\r\n") ; 
                            }
                        
                        __context__.SourceCodeLine = 344;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) ((1 | 256) | 32768) ) ) ; 
                        __context__.SourceCodeLine = 345;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 347;
                            IERRORCODE = (ushort) ( WriteIntegerArray( (short)( NFILEHANDLE ) , IARRAY ) ) ; 
                            __context__.SourceCodeLine = 348;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 349;
                                Print( "Array written to file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 351;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 352;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                { 
                                __context__.SourceCodeLine = 354;
                                Print( "Error closing file\r\n") ; 
                                } 
                            
                            } 
                        
                        __context__.SourceCodeLine = 357;
                        EndFileOperations ( ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void RESTOREFUNC (  SplusExecutionContext __context__, ushort NUMBER_PRESSET ) 
            { 
            ushort NFILEHANDLE = 0;
            ushort IERRORCODE = 0;
            ushort X = 0;
            ushort Y = 0;
            
            CrestronString ID_S;
            ID_S  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            
            __context__.SourceCodeLine = 366;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)NUMBER_PRESSET);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 370;
                        ID_S  .UpdateValue ( "\\CF0\\Presset1_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 371;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 372;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) (0 | 32768) ) ) ; 
                        __context__.SourceCodeLine = 373;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 375;
                            IERRORCODE = (ushort) ( ReadIntegerArray( (short)( NFILEHANDLE ) , ref IARRAY2 ) ) ; 
                            __context__.SourceCodeLine = 376;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 377;
                                Print( "Read array from file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 379;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 380;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 381;
                                Print( "Error closing file\r\n") ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 383;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 387;
                        ID_S  .UpdateValue ( "\\CF0\\Presset2_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 388;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 389;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) (0 | 32768) ) ) ; 
                        __context__.SourceCodeLine = 390;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 392;
                            IERRORCODE = (ushort) ( ReadIntegerArray( (short)( NFILEHANDLE ) , ref IARRAY2 ) ) ; 
                            __context__.SourceCodeLine = 393;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 394;
                                Print( "Read array from file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 396;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 397;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 398;
                                Print( "Error closing file\r\n") ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 400;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 405;
                        ID_S  .UpdateValue ( "\\CF0\\Presset3_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 406;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 407;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) (0 | 32768) ) ) ; 
                        __context__.SourceCodeLine = 408;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 410;
                            IERRORCODE = (ushort) ( ReadIntegerArray( (short)( NFILEHANDLE ) , ref IARRAY2 ) ) ; 
                            __context__.SourceCodeLine = 411;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 412;
                                Print( "Read array from file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 414;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 415;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 416;
                                Print( "Error closing file\r\n") ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 418;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 423;
                        ID_S  .UpdateValue ( "\\CF0\\Presset4_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 424;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 425;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) (0 | 32768) ) ) ; 
                        __context__.SourceCodeLine = 426;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 428;
                            IERRORCODE = (ushort) ( ReadIntegerArray( (short)( NFILEHANDLE ) , ref IARRAY2 ) ) ; 
                            __context__.SourceCodeLine = 429;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 430;
                                Print( "Read array from file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 432;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 433;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 434;
                                Print( "Error closing file\r\n") ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 436;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 441;
                        ID_S  .UpdateValue ( "\\CF0\\Presset5_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 442;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 443;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) (0 | 32768) ) ) ; 
                        __context__.SourceCodeLine = 444;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 446;
                            IERRORCODE = (ushort) ( ReadIntegerArray( (short)( NFILEHANDLE ) , ref IARRAY2 ) ) ; 
                            __context__.SourceCodeLine = 447;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 448;
                                Print( "Read array from file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 450;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 451;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 452;
                                Print( "Error closing file\r\n") ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 454;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 459;
                        ID_S  .UpdateValue ( "\\CF0\\Presset6_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 460;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 461;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) (0 | 32768) ) ) ; 
                        __context__.SourceCodeLine = 462;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 464;
                            IERRORCODE = (ushort) ( ReadIntegerArray( (short)( NFILEHANDLE ) , ref IARRAY2 ) ) ; 
                            __context__.SourceCodeLine = 465;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 466;
                                Print( "Read array from file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 468;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 469;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 470;
                                Print( "Error closing file\r\n") ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 472;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 477;
                        ID_S  .UpdateValue ( "\\CF0\\Presset7_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 478;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 479;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) (0 | 32768) ) ) ; 
                        __context__.SourceCodeLine = 480;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 482;
                            IERRORCODE = (ushort) ( ReadIntegerArray( (short)( NFILEHANDLE ) , ref IARRAY2 ) ) ; 
                            __context__.SourceCodeLine = 483;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 484;
                                Print( "Read array from file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 486;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 487;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 488;
                                Print( "Error closing file\r\n") ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 490;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 8) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 495;
                        ID_S  .UpdateValue ( "\\CF0\\Presset8_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 496;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 497;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) (0 | 32768) ) ) ; 
                        __context__.SourceCodeLine = 498;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 500;
                            IERRORCODE = (ushort) ( ReadIntegerArray( (short)( NFILEHANDLE ) , ref IARRAY2 ) ) ; 
                            __context__.SourceCodeLine = 501;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 502;
                                Print( "Read array from file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 504;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 505;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 506;
                                Print( "Error closing file\r\n") ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 508;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 9) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 513;
                        ID_S  .UpdateValue ( "\\CF0\\Presset9_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 514;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 515;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) (0 | 32768) ) ) ; 
                        __context__.SourceCodeLine = 516;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 518;
                            IERRORCODE = (ushort) ( ReadIntegerArray( (short)( NFILEHANDLE ) , ref IARRAY2 ) ) ; 
                            __context__.SourceCodeLine = 519;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 520;
                                Print( "Read array from file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 522;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 523;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 524;
                                Print( "Error closing file\r\n") ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 526;
                        EndFileOperations ( ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 10) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 531;
                        ID_S  .UpdateValue ( "\\CF0\\Presset10_" + Functions.ItoA (  (int) ( ID_NUM  .Value ) )  ) ; 
                        __context__.SourceCodeLine = 532;
                        StartFileOperations ( ) ; 
                        __context__.SourceCodeLine = 533;
                        NFILEHANDLE = (ushort) ( FileOpen( ID_S ,(ushort) (0 | 32768) ) ) ; 
                        __context__.SourceCodeLine = 534;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NFILEHANDLE >= 0 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 536;
                            IERRORCODE = (ushort) ( ReadIntegerArray( (short)( NFILEHANDLE ) , ref IARRAY2 ) ) ; 
                            __context__.SourceCodeLine = 537;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IERRORCODE > 0 ))  ) ) 
                                {
                                __context__.SourceCodeLine = 538;
                                Print( "Read array from file correctly.\r\n") ; 
                                }
                            
                            else 
                                {
                                __context__.SourceCodeLine = 540;
                                Print( "Error code {0:d}\r\n", (short)IERRORCODE) ; 
                                }
                            
                            __context__.SourceCodeLine = 541;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FileClose( (short)( NFILEHANDLE ) ) != 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 542;
                                Print( "Error closing file\r\n") ; 
                                }
                            
                            } 
                        
                        __context__.SourceCodeLine = 544;
                        EndFileOperations ( ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 548;
            Functions.Delay (  (int) ( 100 ) ) ; 
            __context__.SourceCodeLine = 549;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)150; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 551;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( X < 31 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 553;
                    OUT_A [ X]  .Value = (ushort) ( IARRAY2[ X ] ) ; 
                    } 
                
                __context__.SourceCodeLine = 555;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( X > 30 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 557;
                    Y = (ushort) ( (X - 30) ) ; 
                    __context__.SourceCodeLine = 558;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IARRAY2[ X ] > 0 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 559;
                        Functions.Pulse ( 10, OUT_D_ON [ Y] ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 561;
                        Functions.Pulse ( 10, OUT_D_OFF [ Y] ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 549;
                } 
            
            
            }
            
        object RECALL_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort X = 0;
                
                
                __context__.SourceCodeLine = 598;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)10; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 600;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PRESSET[ X ] .Value > 0 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 602;
                        RESTOREFUNC (  __context__ , (ushort)( X )) ; 
                        } 
                    
                    __context__.SourceCodeLine = 598;
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object STORE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort X = 0;
            
            
            __context__.SourceCodeLine = 610;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)10; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 612;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PRESSET[ X ] .Value > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 614;
                    STOREFUNC (  __context__ , (ushort)( X )) ; 
                    } 
                
                __context__.SourceCodeLine = 610;
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    IARRAY  = new ushort[ 151 ];
    IARRAY2  = new ushort[ 151 ];
    
    STORE = new Crestron.Logos.SplusObjects.DigitalInput( STORE__DigitalInput__, this );
    m_DigitalInputList.Add( STORE__DigitalInput__, STORE );
    
    RECALL = new Crestron.Logos.SplusObjects.DigitalInput( RECALL__DigitalInput__, this );
    m_DigitalInputList.Add( RECALL__DigitalInput__, RECALL );
    
    PRESSET = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        PRESSET[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( PRESSET__DigitalInput__ + i, PRESSET__DigitalInput__, this );
        m_DigitalInputList.Add( PRESSET__DigitalInput__ + i, PRESSET[i+1] );
    }
    
    INPUT_D = new InOutArray<DigitalInput>( 120, this );
    for( uint i = 0; i < 120; i++ )
    {
        INPUT_D[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_D__DigitalInput__ + i, INPUT_D__DigitalInput__, this );
        m_DigitalInputList.Add( INPUT_D__DigitalInput__ + i, INPUT_D[i+1] );
    }
    
    OUT_D_ON = new InOutArray<DigitalOutput>( 120, this );
    for( uint i = 0; i < 120; i++ )
    {
        OUT_D_ON[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( OUT_D_ON__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( OUT_D_ON__DigitalOutput__ + i, OUT_D_ON[i+1] );
    }
    
    OUT_D_OFF = new InOutArray<DigitalOutput>( 120, this );
    for( uint i = 0; i < 120; i++ )
    {
        OUT_D_OFF[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( OUT_D_OFF__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( OUT_D_OFF__DigitalOutput__ + i, OUT_D_OFF[i+1] );
    }
    
    INPUT_A = new InOutArray<AnalogInput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        INPUT_A[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( INPUT_A__AnalogSerialInput__ + i, INPUT_A__AnalogSerialInput__, this );
        m_AnalogInputList.Add( INPUT_A__AnalogSerialInput__ + i, INPUT_A[i+1] );
    }
    
    OUT_A = new InOutArray<AnalogOutput>( 30, this );
    for( uint i = 0; i < 30; i++ )
    {
        OUT_A[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( OUT_A__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( OUT_A__AnalogSerialOutput__ + i, OUT_A[i+1] );
    }
    
    ID_NUM = new UShortParameter( ID_NUM__Parameter__, this );
    m_ParameterList.Add( ID_NUM__Parameter__, ID_NUM );
    
    
    RECALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( RECALL_OnPush_0, false ) );
    STORE.OnDigitalPush.Add( new InputChangeHandlerWrapper( STORE_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PRESSET ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint STORE__DigitalInput__ = 0;
const uint RECALL__DigitalInput__ = 1;
const uint PRESSET__DigitalInput__ = 2;
const uint INPUT_D__DigitalInput__ = 12;
const uint INPUT_A__AnalogSerialInput__ = 0;
const uint OUT_D_ON__DigitalOutput__ = 0;
const uint OUT_D_OFF__DigitalOutput__ = 120;
const uint OUT_A__AnalogSerialOutput__ = 0;
const uint ID_NUM__Parameter__ = 10;

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

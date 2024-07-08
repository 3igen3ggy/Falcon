namespace System;

class ConsoleApp
{
    static void Main(string[] args)
    {
        //SimToggleAutopilot 1076 0 0X1E 0 0 0 1 "Ckpit-Autopilot"
        // action, soundId, callBack, keyboardButton, modifier, null, null, showInGameUI, name

        string keyfile = "SimToggleAutopilot 1076 0 0X1E 0 0 0 1 \"\"Ckpit-Autopilot\"\"\r\nAFBrakesIn -1 0 0X30 2 0 0 1 \"\"Ckpit-Air brakes close\"\"\r\nAFBrakesOut -1 0 0X30 1 0 0 1 \"\"Ckpit-Air brakes open\"\"\r\nAFBrakesToggle -1 0 0X30 0 0 0 1 \"\"Ckpit-Air brakes toggle\"\"\r\nSimToggleExtLights 1084 0 0X26 5 0 0 1 \"\"Ckpit-Aircraft lights\"\"\r\nSimIncAirSource 1140 0 0X3E 3 0 0 1 \"\"Ckpit-Air Source Inc\"\"\r\nSimDecAirSource 1140 0 0X3D 3 0 0 1 \"\"Ckpit-Air Source Dec\"\"\r\nSimAPOverride -1 0 0X4 2 0 0 1 \"\"Ckpit-AP Override\"\"\r\nSimLeftAPSwitch 1148 0 0X2 2 0 0 1 \"\"Ckpit-AP Switch Left\"\"\r\nSimRightAPSwitch 1150 0 0X3 2 0 0 1 \"\"Ckpit-AP Switch Right\"\"\r\nDecreaseAlow -1 0 0X33 4 0 0 1 \"\"Ckpit-ALOW altitude dec\"\"\r\nIncreaseAlow -1 0 0X34 4 0 0 1 \"\"Ckpit-ALOW altitude inc\"\"\r\nSimCycleLeftAuxComDigit 1077 0 0X3B 4 0 0 1 \"\"Ckpit-Aux Comm Lft digit\"\"\r\nSimCycleCenterAuxComDigit 1078 0 0X3C 4 0 0 1 \"\"Ckpit-Aux Comm Ctr digit\"\"\r\nSimCycleRightAuxComDigit 1079 0 0X3D 4 0 0 1 \"\"Ckpit-Aux Comm Rt digit\"\"\r\nSimCycleBandAuxComDigit 1080 0 0X3E 4 0 0 1 \"\"Ckpit-Aux Comm Band X/Y\"\"\r\nSimToggleAuxComMaster 1081 0 0X3F 4 0 0 1 \"\"Ckpit-Aux Comm UFC/Backup\"\"\r\nSimToggleAuxComAATR 1082 0 0X40 4 0 0 1 \"\"Ckpit-Aux Comm AA/TR\"\"\r\nSimToggleUHFMaster 1083 0 0X41 4 0 0 1 \"\"Ckpit-UHF Normal/Backup\"\"\r\nSimAVTRToggle 1010 0 0X21 0 0 0 1 \"\"Ckpit-AVTR\"\"\r\nSimSilenceHorn 1008 0 0X22 2 0 0 1 \"\"Ckpit-Betty gear horn\"\"\r\nExtinguishMasterCaution 1065 0 0X2E 2 0 0 1 \"\"Ckpit-Betty Master Caution\"\"\r\nSimCATSwitch 1103 0 0X2E 1 0 0 1 \"\"Ckpit-CAT I/III\"\"\r\nSimToggleDropPattern 1005 0 0X2C 4 0 0 1 \"\"Ckpit-Chaff/Flare auto/manual\"\"\r\nSimDropFlare 1004 0 0X2C 0 0 0 1 \"\"Ckpit-Drop flare\"\"\r\nSimDropChaff 1003 0 0X2D 0 0 0 1 \"\"Ckpit-Drop chaff\"\"\r\nSimSelectSRMOverride -1 0 0X20 0 0 0 1 \"\"Ckpit-Dogfight override mode\"\"\r\nSimECMOn 1072 0 0X24 0 0 0 1 \"\"Ckpit-ECM\"\"\r\nSimEject 1074 0 0X12 2 0 0 1 \"\"Ckpit-Eject\"\"\r\nSimEpuToggle 1118 0 0X12 4 0 0 1 \"\"Ckpit-EPU step\"\"\r\nSimICPFAck 1017 0 0X21 2 0 0 1 \"\"Ckpit-F ACK\"\"\r\nSimFCCSubModeStep -1 0 0X28 0 0 0 1 \"\"Ckpit-FCC submodes\"\"\r\nSimFuelDoorToggle 1145 0 0X13 3 0 0 1 \"\"Ckpit-Fuel Door\"\"\r\nSimToggleMasterFuel 1138 0 0X41 3 0 0 1 \"\"Ckpit-Fuel Master Switch\"\"\r\nSimFuelDump -1 0 0X20 4 0 0 1 \"\"Ckpit-Dump Fuel\"\"\r\nSimDecFuelPump 1136 0 0X3F 3 0 0 1 \"\"Ckpit-Fuel Pump Switch Dec\"\"\r\nSimIncFuelPump 1136 0 0X40 3 0 0 1 \"\"Ckpit-Fuel Pump Switch Inc\"\"\r\nSimDecFuelSwitch 1135 0 0X3B 3 0 0 1 \"\"Ckpit-Fuel Switch Dec\"\"\r\nSimIncFuelSwitch 1135 0 0X3C 3 0 0 1 \"\"Ckpit-Fuel Switch Inc\"\"\r\nSimInteriorLight -1 0 0X26 3 0 0 1 \"\"Ckpit-Instrument lights\"\"\r\nSimEmergencyJettison 1009 0 0X24 2 0 0 1 \"\"Ckpit-Jettison all\"\"\r\nSimJfsStart 1117 0 0X24 1 0 0 1 \"\"Ckpit-JFS switch\"\"\r\nKneeboardTogglePage -1 0 0X25 4 0 0 1 \"\"Ckpit-Kneeboard page\"\"\r\nAFGearToggle -1 0 0X22 0 0 0 1 \"\"Ckpit-Landing gear\"\"\r\nAFGearUp -1 0 0X22 1 0 0 1 \"\"Ckpit-Landing gear Up\"\"\r\nAFGearDown -1 0 0X22 4 0 0 1 \"\"Ckpit-Landing gear Down\"\"\r\nAFAlternateGear 1141 0 0X22 7 0 0 1 \"\"Ckpit-Alternate Landing Gear\"\"\r\nAFAlternateGearReset 1147 0 0X22 3 0 0 1 \"\"Ckpit-Reset Alt Gear Extension\"\"\r\nSimLandingLightToggle 1142 0 0X26 6 0 0 1 \"\"Ckpit-Landing light\"\"\r\nSimLaserArmToggle 1144 0 0X26 4 0 0 1 \"\"Ckpit-Laser Arm\"\"\r\nSimStepMasterArm 1097 0 0X32 7 0 0 1 \"\"Ckpit-Master Arm cycle\"\"\r\nSimArmMasterArm 1097 0 0X32 1 0 0 1 \"\"Ckpit-Master Arm on\"\"\r\nSimSafeMasterArm 1097 0 0X32 2 0 0 1 \"\"Ckpit-Master Arm safe\"\"\r\nSimSimMasterArm 1097 0 0X32 4 0 0 1 \"\"Ckpit-Master Arm sim\"\"\r\nSimMPOToggle 1007 0 0X18 0 0 0 1 \"\"Ckpit-Manual pitch override\"\"\r\nSimSelectMRMOverride -1 0 0X32 0 0 0 1 \"\"Ckpit-MRM override mode\"\"\r\nSimDeselectOverride -1 0 0X2E 0 0 0 1 \"\"Ckpit-MRM/DF override cancel\"\"\r\nToggleNVGMode -1 0 0X31 0 0 0 1 \"\"Ckpit-NVG\"\"\r\nSimParkingBrakeToggle 1143 0 0X19 4 0 0 1 \"\"Ckpit-Parking brake\"\"\r\nSimDLPower 1128 0 0X57 5 0 0 1 \"\"Ckpit-Power Datalink\"\"\r\nSimFCCPower 1124 0 0X40 5 0 0 1 \"\"Ckpit-Power FCC\"\"\r\nSimFCRPower 1134 0 0X3F 5 0 0 1 \"\"Ckpit-Power FCR\"\"\r\nSimGPSPower 1127 0 0X44 5 0 0 1 \"\"Ckpit-Power GPS\"\"\r\nSimHUDPower 1133 0 0X3C 5 0 0 1 \"\"Ckpit-Power HUD\"\"\r\nSimMainPowerDec 1156 0 0X3B 6 0 0 1 \"\"Ckpit-Power Main Dec\"\"\r\nSimMainPowerInc 1156 0 0X3C 6 0 0 1 \"\"Ckpit-Power Main Inc\"\"\r\nSimMAPPower 1129 0 0X58 5 0 0 1 \"\"Ckpit-Power MAP\"\"\r\nSimMFDPower 1125 0 0X42 5 0 0 1 \"\"Ckpit-Power MFD\"\"\r\nSimSMSPower 1123 0 0X41 5 0 0 1 \"\"Ckpit-Power SMS\"\"\r\nSimTISLPower 1130 0 0X3B 5 0 0 1 \"\"Ckpit-Power TISL\"\"\r\nSimUFCPower 1126 0 0X43 5 0 0 1 \"\"Ckpit-Power UFC\"\"\r\nSimLeftHptPower 1131 0 0X3D 5 0 0 1 \"\"Ckpit-Power Left Hpt\"\"\r\nSimRightHptPower 1132 0 0X3E 5 0 0 1 \"\"Ckpit-Power Right Hpt\"\"\r\nSimSeatArm -1 0 0X12 3 0 0 1 \"\"Ckpit-SeatArm\"\"\r\nToggleSmoke -1 0 0X1F 2 0 0 1 \"\"Sim-Smoke toggle\"\"\r\nSimNextWaypoint -1 0 0X1F 0 0 0 1 \"\"Ckpit-Steerpoint next\"\"\r\nSimPrevWaypoint -1 0 0X1F 1 0 0 1 \"\"Ckpit-Steerpoint previous\"\"\r\nSimToggleTFR 1076 0 0X1E 3 0 0 1 \"\"Ckpit-Terrain Following Radar\"\"\r\nSimWheelBrakes -1 0 0X25 0 0 0 1 \"\"Ckpit-Wheel brakes\"\"\r\nSimThrottleIdleDetent -1 0 0X17 4 0 0 1 \"\"Ctrls-Throttle Idle Detent\"\"\r\nAFIdle -1 0 0XC 4 0 0 1 \"\"Ctrls-Throttle Idle\"\"\r\nAFCoarseThrottleDown -1 0 0XC 1 0 0 1 \"\"Ctrls-Step throttle down\"\"\r\nAFThrottleDown -1 0 0XC 0 0 0 1 \"\"Ctrls-Throttle back\"\"\r\nAFThrottleUp -1 0 0XD 0 0 0 1 \"\"Ctrls-Throttle forward\"\"\r\nAFCoarseThrottleUp -1 0 0XD 1 0 0 1 \"\"Ctrls-Step throttle up\"\"\r\nAFABOn -1 0 0XC 2 0 0 1 \"\"Ctrls-Min Afterburner\"\"\r\nAFABFull -1 0 0XD 2 0 0 1 \"\"Ctrls-Full afterburner\"\"\r\nAFAileronRight -1 0 0XCD 0 0 0 1 \"\"Ctrls-Roll right\"\"\r\nAFAileronLeft -1 0 0XCB 0 0 0 1 \"\"Ctrls-Roll left\"\"\r\nAFElevatorUp -1 0 0XD0 0 0 0 1 \"\"Ctrls-Nose up\"\"\r\nAFElevatorDown -1 0 0XC8 0 0 0 1 \"\"Ctrls-Nose down\"\"\r\nAFRudderLeft -1 0 0X33 0 0 0 1 \"\"Ctrls-Rudder left\"\"\r\nAFRudderRight -1 0 0X34 0 0 0 1 \"\"Ctrls-Rudder right\"\"\r\nSimEWSChaffPower 1160 0 0X3D 6 0 0 1 \"\"EWS-Chaff Power\"\"\r\nSimEWSFlarePower 1161 0 0X3E 6 0 0 1 \"\"EWS-Flare Power\"\"\r\nSimEWSJammerPower 1159 0 0X3F 6 0 0 1 \"\"EWS-Jammer Power\"\"\r\nSimEWSPGMDec 1162 0 0X2C 1 0 0 1 \"\"EWS-PGM Dec\"\"\r\nSimEWSPGMInc 1162 0 0X2D 1 0 0 1 \"\"EWS-PGM Inc\"\"\r\nSimEWSProgDec 11621 0 0X10 1 0 0 1 \"\"EWS-Program Dec\"\"\r\nSimEWSProgInc 11621 0 0X11 1 0 0 1 \"\"EWS-Program Inc\"\"\r\nSimEWSRWRPower 1158 0 0X40 6 0 0 1 \"\"EWS-RWR Power\"\"\r\nSimHsiCourseDec 1001 0 0X2F 6 0 0 1 \"\"HSI-Course decrement\"\"\r\nSimHsiCourseInc 1001 0 0X30 6 0 0 1 \"\"HSI-Course increment\"\"\r\nSimHsiHeadingDec 1002 0 0X31 6 0 0 1 \"\"HSI-Heading decrement\"\"\r\nSimHsiHeadingInc 1002 0 0X32 6 0 0 1 \"\"HSI-Heading increment\"\"\r\nSimStepHSIMode 1006 0 0X17 0 0 0 1 \"\"HSI-Modes toggle\"\"\r\nSimHookToggle 1167 0 0X25 2 0 0 1 \"\"Ckpit-Hook\"\"\r\nSimHUDRadar 1070 0 0X1E 7 0 0 1 \"\"HUD-Altimeter type\"\"\r\nSimHUDBrightness 1071 0 0X30 7 0 0 1 \"\"HUD-Brightness\"\"\r\nSimHUDBrightnessDown -1 0 0X2C 7 0 0 1 \"\"HUD-Brightness Down\"\"\r\nSimHUDBrightnessUp -1 0 0X2D 7 0 0 1 \"\"HUD-Brightness Up\"\"\r\nOTWStepHudColor -1 0 0X2E 7 0 0 1 \"\"HUD-Color\"\"\r\nOTWToggleScales 1066 0 0X23 0 0 0 1 \"\"HUD-Scale type\"\"\r\nSimHUDDED 1068 0 0X20 7 0 0 1 \"\"HUD-Display DED\"\"\r\nSimFLIRToggle -1 0 0X23 1 0 0 1 \"\"HUD-Display FLIR\"\"\r\nOTWStepHeadingScale -1 0 0X1F 7 0 0 1 \"\"HUD-Heading scales\"\"\r\nOTWTogglePitchLadder 1067 0 0X19 7 0 0 1 \"\"HUD-Pitch ladder\"\"\r\nSimHUDVelocity 1069 0 0X2F 7 0 0 1 \"\"HUD-Velocity cues\"\"\r\nSimWarnReset 1153 0 0X11 7 0 0 1 \"\"HUD-Warning reset\"\"\r\nSimICPCom1 1011 0 0XB5 1 0 0 1 \"\"ICP-COM1\"\"\r\nSimICPCom2 1091 0 0X37 1 0 0 1 \"\"ICP-COM2\"\"\r\nSimICPIFF 1105 0 0X47 1 0 0 1 \"\"ICP-IFF\"\"\r\nSimICPLIST 1104 0 0X49 1 0 0 1 \"\"ICP-LIST\"\"\r\nSimICPNav 1012 0 0X9C 1 0 0 1 \"\"ICP-NAV\"\"\r\nSimICPAA 1013 0 0X52 1 0 0 1 \"\"ICP-AA\"\"\r\nSimICPAG 1014 0 0X53 1 0 0 1 \"\"ICP-AG\"\"\r\nSimICPDEDDOWN 1114 0 0XCF 2 0 0 1 \"\"ICP-DCS Down\"\"\r\nSimICPDEDUP 1113 0 0XC7 2 0 0 1 \"\"ICP-DCS Up\"\"\r\nSimICPDEDSEQ 1115 0 0XC9 2 0 0 1 \"\"ICP-DCS Seq\"\"\r\nSimICPResetDED 1112 0 0XD2 2 0 0 1 \"\"ICP-DCS Return\"\"\r\nSimICPCLEAR 1111 0 0XD3 2 0 0 1 \"\"ICP-Reset\"\"\r\nSimICPTILS 1015 0 0X47 2 0 0 1 \"\"ICP-1 ILS\"\"\r\nSimICPALOW 1016 0 0X48 2 0 0 1 \"\"ICP-2 ALOW\"\"\r\nSimICPTHREE 1107 0 0X49 2 0 0 1 \"\"ICP-3\"\"\r\nSimICPStpt 1018 0 0X4B 2 0 0 1 \"\"ICP-4 STPT\"\"\r\nSimICPCrus 1019 0 0X4C 2 0 0 1 \"\"ICP-5 CRUS\"\"\r\nSimICPSIX 1108 0 0X4D 2 0 0 1 \"\"ICP-6 TIME\"\"\r\nSimICPMark 1021 0 0X4F 2 0 0 1 \"\"ICP-7 MARK\"\"\r\nSimICPEIGHT 1109 0 0X50 2 0 0 1 \"\"ICP-8 FIX\"\"\r\nSimICPNINE 1110 0 0X51 2 0 0 1 \"\"ICP-9 A-CAL\"\"\r\nSimICPZERO 1106 0 0X52 2 0 0 1 \"\"ICP-0 M-SEL\"\"\r\nSimICPEnter 1022 0 0X9C 2 0 0 1 \"\"ICP-Enter\"\"\r\nSimICPLink 1020 0 0X20 2 0 0 1 \"\"ICP-DLNK\"\"\r\nSimICPNext 1024 0 0X4E 2 0 0 1 \"\"ICP-Next\"\"\r\nSimICPPrevious 1023 0 0X4A 2 0 0 1 \"\"ICP-Previous\"\"\r\nSimDriftCO 1116 0 0XD1 2 0 0 1 \"\"ICP-Drift C/O\"\"\r\nOTWStepMFD1 -1 0 0X1A 0 0 0 1 \"\"MFD-Step 1\"\"\r\nOTWStepMFD2 -1 0 0X1B 0 0 0 1 \"\"MFD-Step 2\"\"\r\nOTWStepMFD3 -1 0 0X1B 1 0 0 1 \"\"MFD-Step 3\"\"\r\nOTWStepMFD4 -1 0 0X1A 1 0 0 1 \"\"MFD-Step 4\"\"\r\nSimCBEOSB_GAINDOWN_L 1101 0 0X21 6 0 0 1 \"\"LeftMFD-Brightness Down\"\"\r\nSimCBEOSB_GAINUP_L 1100 0 0X22 6 0 0 1 \"\"LeftMFD-Brightness Up\"\"\r\nSimCBEOSB_1L 1025 0 0X2 6 0 0 1 \"\"LeftMFD-OSB 01\"\"\r\nSimCBEOSB_2L 1026 0 0X3 6 0 0 1 \"\"LeftMFD-OSB 02\"\"\r\nSimCBEOSB_3L 1027 0 0X4 6 0 0 1 \"\"LeftMFD-OSB 03\"\"\r\nSimCBEOSB_4L 1028 0 0X5 6 0 0 1 \"\"LeftMFD-OSB 04\"\"\r\nSimCBEOSB_5L 1029 0 0X6 6 0 0 1 \"\"LeftMFD-OSB 05\"\"\r\nSimCBEOSB_6L 1030 0 0X7 6 0 0 1 \"\"LeftMFD-OSB 06\"\"\r\nSimCBEOSB_7L 1031 0 0X8 6 0 0 1 \"\"LeftMFD-OSB 07\"\"\r\nSimCBEOSB_8L 1032 0 0X9 6 0 0 1 \"\"LeftMFD-OSB 08\"\"\r\nSimCBEOSB_9L 1033 0 0XA 6 0 0 1 \"\"LeftMFD-OSB 09\"\"\r\nSimCBEOSB_10L 1034 0 0XB 6 0 0 1 \"\"LeftMFD-OSB 10\"\"\r\nSimCBEOSB_11L 1039 0 0X4F 6 0 0 1 \"\"LeftMFD-OSB 11\"\"\r\nSimCBEOSB_12L 1038 0 0X50 6 0 0 1 \"\"LeftMFD-OSB 12\"\"\r\nSimCBEOSB_13L 1037 0 0X51 6 0 0 1 \"\"LeftMFD-OSB 13\"\"\r\nSimCBEOSB_14L 1036 0 0X4B 6 0 0 1 \"\"LeftMFD-OSB 14\"\"\r\nSimCBEOSB_15L 1035 0 0X4C 6 0 0 1 \"\"LeftMFD-OSB 15\"\"\r\nSimCBEOSB_16L 1044 0 0X4D 6 0 0 1 \"\"LeftMFD-OSB 16\"\"\r\nSimCBEOSB_17L 1043 0 0X47 6 0 0 1 \"\"LeftMFD-OSB 17\"\"\r\nSimCBEOSB_18L 1042 0 0X48 6 0 0 1 \"\"LeftMFD-OSB 18\"\"\r\nSimCBEOSB_19L 1041 0 0X49 6 0 0 1 \"\"LeftMFD-OSB 19\"\"\r\nSimCBEOSB_20L 1040 0 0X52 6 0 0 1 \"\"LeftMFD-OSB 20\"\"\r\nSimCBEOSB_GAINDOWN_R 1099 0 0X21 5 0 0 1 \"\"RightMFD-Brightness Down\"\"\r\nSimCBEOSB_GAINUP_R 1098 0 0X22 5 0 0 1 \"\"RightMFD-Brightness Up\"\"\r\nSimCBEOSB_1R 1045 0 0X2 5 0 0 1 \"\"RightMFD-OSB 01\"\"\r\nSimCBEOSB_2R 1046 0 0X3 5 0 0 1 \"\"RightMFD-OSB 02\"\"\r\nSimCBEOSB_3R 1047 0 0X4 5 0 0 1 \"\"RightMFD-OSB 03\"\"\r\nSimCBEOSB_4R 1048 0 0X5 5 0 0 1 \"\"RightMFD-OSB 04\"\"\r\nSimCBEOSB_5R 1049 0 0X6 5 0 0 1 \"\"RightMFD-OSB 05\"\"\r\nSimCBEOSB_6R 1050 0 0X7 5 0 0 1 \"\"RightMFD-OSB 06\"\"\r\nSimCBEOSB_7R 1051 0 0X8 5 0 0 1 \"\"RightMFD-OSB 07\"\"\r\nSimCBEOSB_8R 1052 0 0X9 5 0 0 1 \"\"RightMFD-OSB 08\"\"\r\nSimCBEOSB_9R 1053 0 0XA 5 0 0 1 \"\"RightMFD-OSB 09\"\"\r\nSimCBEOSB_10R 1054 0 0XB 5 0 0 1 \"\"RightMFD-OSB 10\"\"\r\nSimCBEOSB_11R 1059 0 0X4F 5 0 0 1 \"\"RightMFD-OSB 11\"\"\r\nSimCBEOSB_12R 1058 0 0X50 5 0 0 1 \"\"RightMFD-OSB 12\"\"\r\nSimCBEOSB_13R 1057 0 0X51 5 0 0 1 \"\"RightMFD-OSB 13\"\"\r\nSimCBEOSB_14R 1056 0 0X4B 5 0 0 1 \"\"RightMFD-OSB 14\"\"\r\nSimCBEOSB_15R 1055 0 0X4C 5 0 0 1 \"\"RightMFD-OSB 15\"\"\r\nSimCBEOSB_16R 1064 0 0X4D 5 0 0 1 \"\"RightMFD-OSB 16\"\"\r\nSimCBEOSB_17R 1063 0 0X47 5 0 0 1 \"\"RightMFD-OSB 17\"\"\r\nSimCBEOSB_18R 1062 0 0X48 5 0 0 1 \"\"RightMFD-OSB 18\"\"\r\nSimCBEOSB_19R 1061 0 0X49 5 0 0 1 \"\"RightMFD-OSB 19\"\"\r\nSimCBEOSB_20R 1060 0 0X52 5 0 0 1 \"\"RightMFD-OSB 20\"\"\r\nSimACM30x20 -1 0 0X40 2 0 0 1 \"\"Radar-ACM 30x20\"\"\r\nSimACMBoresight -1 0 0X3F 2 0 0 1 \"\"Radar-ACM boresight\"\"\r\nSimACMSlew -1 0 0X41 2 0 0 1 \"\"Radar-ACM slewable\"\"\r\nSimACMVertical -1 0 0X42 2 0 0 1 \"\"Radar-ACM vertical\"\"\r\nSimRadarAAModeStep -1 0 0X3B 0 0 0 1 \"\"Radar-Air to Air\"\"\r\nSimRadarAGModeStep -1 0 0X3C 0 0 0 1 \"\"Radar-Air to Ground\"\"\r\nSimRadarElevationDown -1 0 0X3F 0 0 0 1 \"\"Radar-Antenna tilt down\"\"\r\nSimRadarElevationUp -1 0 0X41 0 0 0 1 \"\"Radar-Antenna tilt up\"\"\r\nSimRadarElevationCenter -1 0 0X40 0 0 0 1 \"\"Radar-Antenna center\"\"\r\nSimRadarBarScanChange -1 0 0X42 1 0 0 1 \"\"Radar-Bar scan\"\"\r\nSimCursorDown -1 0 0XD0 4 0 0 1 \"\"Radar-Cursor down\"\"\r\nSimCursorLeft -1 0 0XCB 4 0 0 1 \"\"Radar-Cursor left\"\"\r\nSimCursorRight -1 0 0XCD 4 0 0 1 \"\"Radar-Cursor right\"\"\r\nSimCursorUp -1 0 0XC8 4 0 0 1 \"\"Radar-Cursor up\"\"\r\nSimRadarCursorZero -1 0 0XD0 1 0 0 1 \"\"Radar-cursors reset\"\"\r\nSimDesignate -1 0 0X52 0 0 0 1 \"\"Radar-Designate target\"\"\r\nSimRadarGainDown -1 0 0X3D 1 0 0 1 \"\"Radar-gain decrease\"\"\r\nSimRadarGainUp -1 0 0X3E 1 0 0 1 \"\"Radar-gain increase\"\"\r\nSimRadarFOVStep -1 0 0X43 1 0 0 1 \"\"Radar-GM FOV\"\"\r\nSimRadarFreeze -1 0 0X44 0 0 0 1 \"\"Radar-GM picture freeze\"\"\r\nSimRadarSnowplow -1 0 0X44 1 0 0 1 \"\"Radar-GM snowplow\"\"\r\nSimHSDRangeStepDown -1 0 0X57 1 0 0 1 \"\"Radar-HSD range decrease\"\"\r\nSimHSDRangeStepUp -1 0 0X58 1 0 0 1 \"\"Radar-HSD range increase\"\"\r\nSimRadarNextTarget -1 0 0XD1 0 0 0 1 \"\"Radar-lock next target\"\"\r\nSimRadarPrevTarget -1 0 0XD3 0 0 0 1 \"\"Radar-lock previous target\"\"\r\nSimMaverickFOVStep -1 0 0X2F 1 0 0 1 \"\"Radar-Maverick FOV\"\"\r\nSimRadarRangeStepDown -1 0 0X3D 0 0 0 1 \"\"Radar-range decrease\"\"\r\nSimRadarRangeStepUp -1 0 0X3E 0 0 0 1 \"\"Radar-range increase\"\"\r\nSimRangeKnobDown -1 0 0X3D 2 0 0 1 \"\"Radar-Range Knob Down\"\"\r\nSimRangeKnobUp -1 0 0X3E 2 0 0 1 \"\"Radar-Range Knob Up\"\"\r\nSimDropTrack -1 0 0X53 0 0 0 1 \"\"Radar-return to search\"\"\r\nSimRFSwitch 1165 0 0X13 5 0 0 1 \"\"Radar-RF Inhibit\"\"\r\nSimSOIFOVStep -1 0 0X2F 0 0 0 1 \"\"Radar-SOI FOV\"\"\r\nSimRadarStandby -1 0 0X13 2 0 0 1 \"\"Radar-standby\"\"\r\nSimRadarAzimuthScanChange -1 0 0X57 0 0 0 1 \"\"Radar-submodes/azimuth\"\"\r\nSimRALTOFF 1122 0 0X1E 4 0 0 1 \"\"Ckpit-Radar Altimeter OFF\"\"\r\nSimRALTON 1121 0 0X1E 1 0 0 1 \"\"Ckpit-Radar Altimeter ON\"\"\r\nSimRALTSTDBY 1120 0 0X1E 2 0 0 1 \"\"Ckpit-Radar Altimeter STDBY\"\"\r\nSimCycleRadioChannel 1073 0 0X15 4 0 0 1 \"\"Radio-Channel cycle\"\"\r\nRadioMenuCommand -1 0 0XF 0 0 0 -1 \"\"Radio-Menu\"\"\r\nRadioAWACSCommand -1 0 0X10 0 0 0 -1 \"\"Radio-AWACS command\"\"\r\nRadioWingCommand -1 0 0X11 0 0 0 -1 \"\"Radio-Wingman command\"\"\r\nRadioElementCommand -1 0 0X12 0 0 0 -1 \"\"Radio-Element command\"\"\r\nRadioFlightCommand -1 0 0X13 0 0 0 -1 \"\"Radio-Flight command\"\"\r\nRadioTowerCommand -1 0 0X14 0 0 0 1 \"\"Radio-ATC message\"\"\r\nRadioTankerCommand -1 0 0X15 0 0 0 1 \"\"Radio-Tanker message\"\"\r\nSimRWRSetGroundPriority 1095 0 0XC7 0 0 0 1 \"\"RWR-Low\"\"\r\nSimRWRSetNaval 1089 0 0XC9 1 0 0 1 \"\"RWR-Naval\"\"\r\nSimRWRSetPriority 1087 0 0XD2 0 0 0 1 \"\"RWR-Priority\"\"\r\nSimRWRHandoff 1085 0 0XD1 1 0 0 1 \"\"RWR-Handoff\"\"\r\nSimRWRSetSearch 1094 0 0XD2 1 0 0 1 \"\"RWR-Search\"\"\r\nSimRWRSetTargetSep 1090 0 0XC9 0 0 0 1 \"\"RWR-Target Separate\"\"\r\nSimRWRSetUnknowns 1088 0 0XC7 1 0 0 1 \"\"RWR-Unknown\"\"\r\nTimeAccelerate -1 0 0X3A 0 0 0 1 \"\"Sim-2x time compression\"\"\r\nTimeAccelerateMaxToggle -1 0 0XFFFFFFFF 0 0 0 1 \"\"Sim-4X time acceleration\"\"\r\nSimOpenChatBox -1 0 0X29 0 0 0 1 \"\"Sim-Chat\"\"\r\nSimEndFlight -1 0 0X1 0 0 0 -1 \"\"Sim-Exit\"\"\r\nLoadCockpitDefaults -1 0 0X26 0 0X2E 4 -1 \"\"Sim-cockpit setup load\"\"\r\nSaveCockpitDefaults -1 0 0X1F 0 0X2E 4 -1 \"\"Sim-cockpit setup save\"\"\r\nSimMotionFreeze -1 0 0X19 1 0 0 1 \"\"Sim-Freeze\"\"\r\nOTWToggleNames -1 0 0X26 1 0 0 1 \"\"Sim-labels near\"\"\r\nOTWToggleCampNames -1 0 0X26 2 0 0 1 \"\"Sim-labels far\"\"\r\nSimTogglePaused -1 0 0X19 0 0 0 1 \"\"Sim-Pause\"\"\r\nScreenShot -1 0 0XB7 0 0 0 -1 \"\"Sim-Screen shot\"\"\r\nOTWToggleScoreDisplay -1 0 0X13 4 0 0 1 \"\"Sim-Show score\"\"\r\nSoundOff -1 0 0X1F 4 0 0 1 \"\"Sim-Sound off\"\"\r\nSoundDown -1 0 0X30 4 0 0 1 \"\"Sim-Sound down\"\"\r\nSoundUp -1 0 0X31 4 0 0 1 \"\"Sim-Sound up\"\"\r\nTimeAccelerateDec -1 0 0X3A 2 0 0 1 \"\"Sim-Time Accel Dec\"\"\r\nTimeAccelerateInc -1 0 0X3A 1 0 0 1 \"\"Sim-Time Accel Inc\"\"\r\nSimTMSDown -1 0 0XD0 2 0 0 1 \"\"HOTAS-TMS Down\"\"\r\nSimTMSLeft -1 0 0XCB 2 0 0 1 \"\"HOTAS-TMS Left\"\"\r\nSimTMSRight -1 0 0XCD 2 0 0 1 \"\"HOTAS-TMS Right\"\"\r\nSimTMSUp -1 0 0XC8 2 0 0 1 \"\"HOTAS-TMS Up\"\"\r\nAFRudderTrimLeft -1 0 0XCB 3 0 0 1 \"\"Trim-Rudder Left\"\"\r\nAFRudderTrimRight -1 0 0XCD 3 0 0 1 \"\"Trim-Rudder Right\"\"\r\nAFAileronTrimLeft -1 0 0XCB 1 0 0 1 \"\"Trim-Aileron Left\"\"\r\nAFAileronTrimRight -1 0 0XCD 1 0 0 1 \"\"Trim-Aileron Right\"\"\r\nAFElevatorTrimUp -1 0 0XC8 3 0 0 1 \"\"Trim-Elevator Up\"\"\r\nAFElevatorTrimDown -1 0 0XD0 3 0 0 1 \"\"Trim-Elevator Down\"\"\r\nAFResetTrim -1 0 0XC8 1 0 0 1 \"\"Trim-Reset\"\"\r\nOTWToggleActionCamera -1 0 0X29 1 0 0 1 \"\"View-Action Camera\"\"\r\nOTWStepNextAC -1 0 0X34 1 0 0 1 \"\"View-Aircraft next\"\"\r\nOTWStepPrevAC -1 0 0X33 1 0 0 1 \"\"View-Aircraft previous\"\"\r\nSimToggleGhostMFDs -1 0 0X2 1 0 0 1 \"\"View-Cockpit Ghost MFD Zoom\"\"\r\nSimToggleCockpit -1 0 0X3 1 0 0 1 \"\"View-Cockpit Wide/Normal\"\"\r\nFOVToggle -1 0 0X26 0 0 0 1 \"\"View-Look closer\"\"\r\nOTW1000View -1 0 0X47 7 0 0 1 \"\"View-Cockpit 10:00\"\"\r\nOTW1200LView -1 0 0X52 7 0 0 1 \"\"View-Cockpit lower left\"\"\r\nOTW200View -1 0 0X49 7 0 0 1 \"\"View-Cockpit 2:00\"\"\r\nOTW900View -1 0 0X4B 7 0 0 1 \"\"View-Cockpit 9:00\"\"\r\nOTW300View -1 0 0X4D 7 0 0 1 \"\"View-Cockpit 3:00\"\"\r\nOTWViewReset -1 0 0X4C 7 0 0 1 \"\"View-Reset\"\"\r\nOTW800View -1 0 0X4F 7 0 0 1 \"\"View-Cockpit 8:00\"\"\r\nOTW400View -1 0 0X51 7 0 0 1 \"\"View-Cockpit 4:00\"\"\r\nOTW1200RView -1 0 0X50 7 0 0 1 \"\"View-Cockpit lower right\"\"\r\nOTW1200HUDView -1 0 0XB5 7 0 0 1 \"\"View-Cockpit HUD\"\"\r\nOTWGlanceForward -1 0 0X49 0 0 0 1 \"\"View-Glance forward\"\"\r\nOTWCheckSix -1 0 0X51 0 0 0 1 \"\"View-Glance backward\"\"\r\nOTWViewDown -1 0 0X50 0 0 0 1 \"\"View-Rotate down\"\"\r\nOTWViewLeft -1 0 0X4B 0 0 0 1 \"\"View-Rotate left\"\"\r\nOTWViewRight -1 0 0X4D 0 0 0 1 \"\"View-Rotate right\"\"\r\nOTWViewUp -1 0 0X48 0 0 0 1 \"\"View-Rotate up\"\"\r\nOTWSelect2DCockpitMode -1 0 0X3 0 0 0 1 \"\"View-2D Cockpit\"\"\r\nOTWSelectChaseMode -1 0 0XA 0 0 0 1 \"\"View-Chase\"\"\r\nOTWSelectAirEnemyMode -1 0 0X9 2 0 0 1 \"\"View-Enemy aircraft\"\"\r\nOTWSelectGroundEnemyMode -1 0 0X9 4 0 0 1 \"\"View-Enemy vehicle\"\"\r\nOTWSelectFlybyMode -1 0 0XA 1 0 0 1 \"\"View-Flyby\"\"\r\nOTWSelectEFOVPadlockMode -1 0 0X6 0 0 0 1 \"\"View-Extended FOV\"\"\r\nOTWSelectAirFriendlyMode -1 0 0X9 0 0 0 1 \"\"View-Friendly\"\"\r\nOTWSelectGroundFriendlyMode -1 0 0X9 1 0 0 1 \"\"View-Friendly ground unit\"\"\r\nOTWSelectHUDMode -1 0 0X2 0 0 0 1 \"\"View-HUD Only\"\"\r\nOTWSelectIncomingMode -1 0 0X8 0 0 0 1 \"\"View-Incoming\"\"\r\nOTWSelectOrbitMode -1 0 0XB 0 0 0 1 \"\"View-Orbit\"\"\r\nOTWSelectF3PadlockMode -1 0 0X5 0 0 0 1 \"\"View-Padlock\"\"\r\nOTWStepNextPadlock -1 0 0X4E 0 0 0 1 \"\"View-Padlock next\"\"\r\nOTWStepPrevPadlock -1 0 0X4A 0 0 0 1 \"\"View-Padlock previous\"\"\r\nOTWStepPrevPadlockAA -1 0 0X4A 1 0 0 1 \"\"View-Padlock prev AA\"\"\r\nOTWStepNextPadlockAA -1 0 0X4E 1 0 0 1 \"\"View-Padlock next AA\"\"\r\nOTWStepPrevPadlockAG -1 0 0X4A 4 0 0 1 \"\"View-Padlock prev AG\"\"\r\nOTWStepNextPadlockAG -1 0 0X4E 4 0 0 1 \"\"View-Padlock next AG\"\"\r\nOTWSelectF3PadlockModeAA -1 0 0X5 1 0 0 1 \"\"View-Padlock Mode=AA\"\"\r\nOTWSelectF3PadlockModeAG -1 0 0X5 4 0 0 1 \"\"View-Padlock Mode=AG\"\"\r\nOTWSelectEFOVPadlockModeAA -1 0 0X6 1 0 0 1 \"\"View-Padlock EFOV Mode=AA\"\"\r\nOTWSelectEFOVPadlockModeAG -1 0 0X6 4 0 0 1 \"\"View-Padlock EFOV Mode=AG\"\"\r\nOTWSelectTargetMode -1 0 0X7 1 0 0 1 \"\"View-Target\"\"\r\nOTWTrackExternal -1 0 0X7 0 0 0 1 \"\"View-Tracking\"\"\r\nOTWSelect3DCockpitMode -1 0 0X4 0 0 0 1 \"\"View-Virtual cockpit\"\"\r\nOTWSelectWeaponMode -1 0 0X8 1 0 0 1 \"\"View-Weapon\"\"\r\nOTWTrackTargetToWeapon -1 0 0X8 4 0 0 1 \"\"View-Weapon's target\"\"\r\nOTWToggleSidebar -1 0 0X4 1 0 0 1 \"\"View-Toggle SA bar\"\"\r\nOTWSelectSatelliteMode -1 0 0X29 4 0 0 1 \"\"View-Satellite Camera\"\"\r\nOTWSelectTowerCamMode -1 0 0XB 4 0 0 1 \"\"View-Tower Camera\"\"\r\nOTWViewZoomIn -1 0 0X4F 0 0 0 1 \"\"View-Zoom in\"\"\r\nOTWViewZoomOut -1 0 0X47 0 0 0 1 \"\"View-Zoom out\"\"\r\nSimInhibitVMS 1164 0 0X2F 2 0 0 1 \"\"Ckpit-VMS Inhibit\"\"\r\nSimNextAAWeapon 1013 0 0X1C 0 0 0 1 \"\"Wpn-A to A cycle hardpoints\"\"\r\nSimNextAGWeapon 1014 0 0XE 0 0 0 1 \"\"Wpn-A to G cycle hardpoints\"\"\r\nSimToggleMissileBoreSlave -1 0 0X16 2 0 0 1 \"\"Wpn-Missile Bore/Slave\"\"\r\nSimMissileStep -1 0 0X35 1 0 0 1 \"\"Wpn-Missile Hardpoints cycle\"\"\r\nSimToggleMissileTDBPUncage -1 0 0X16 4 0 0 1 \"\"Wpn-Missile TD/BP\"\"\r\nSimTrigger -1 0 0X35 0 0 0 1 \"\"Wpn-Fire gun\"\"\r\nSimPickle -1 0 0X39 0 0 0 1 \"\"Wpn-Pickle\"\"\r\nBombIntervalDecrement -1 0 0X27 2 0 0 1 \"\"Wpn-Bomb interval dec\"\"\r\nBombIntervalIncrement -1 0 0X28 2 0 0 1 \"\"Wpn-Bomb interval inc\"\"\r\nBombRippleDecrement -1 0 0X27 1 0 0 1 \"\"Wpn-Bomb ripple dec\"\"\r\nBombRippleIncrement -1 0 0X28 1 0 0 1 \"\"Wpn-Bomb ripple inc\"\"\r\nBombBurstDecrement -1 0 0X33 2 0 0 1 \"\"Wpn-CBU burst altitude dec\"\"\r\nBombBurstIncrement -1 0 0X34 2 0 0 1 \"\"Wpn-CBU burst altitude inc\"\"\r\nSimReticleSwitch 1154 0 0X32 3 0 0 1 \"\"Wpn-MAN Reticle\"\"\r\nBombSGLRelease -1 0 0X27 4 0 0 1 \"\"Wpn-Release bombs singly\"\"\r\nBombPairRelease -1 0 0X28 4 0 0 1 \"\"Wpn-Release bombs in pairs\"\"\r\nSimToggleMissileCage -1 0 0X16 0 0 0 1 \"\"Wpn-Sidewinder-Cage/Uncage\"\"\r\nSimToggleMissileSpotScan -1 0 0X16 1 0 0 1 \"\"Wpn-Sidewinder Spot/Scan\"\"\r\nCommandsSetKeyCombo -1 0 0X2C 2 0 0 -1 \"\"Key-Combination Ctrl-Z\"\"\r\nCommandsSetKeyCombo -1 0 0X2D 2 0 0 -1 \"\"Key-Combination Ctrl-X\"\"\r\nCommandsSetKeyCombo -1 0 0X2E 4 0 0 -1 \"\"Key-Combination Alt-C\"\"\r\nSimCursorEnable -1 0 0X31 1 0 0 1 \"\"HOTAS-Cursor enable\"\"\r\nSimPinkySwitch -1 0 0X2F 4 0 0 1 \"\"HOTAS-Pinky Switch\"\"\r\nSimGndJettEnable 1169 0 0X24 4 0 0 1 \"\"Ckpit-Ground Jett enable\"\"\r\nSimExtlPower 1171 0 0X43 6 0 0 1 \"\"Lights-Extl Power\"\"\r\nSimExtlAntiColl 1084 0 0X44 6 0 0 1 \"\"Lights-Extl Anti Coll\"\"\r\nSimExtlSteady 1172 0 0X58 6 0 0 1 \"\"Lights-Extl Steady\"\"\r\nSimExtlWing 1173 0 0X57 6 0 0 1 \"\"Lights-Extl Wing\"\"\r\nSimDMSUp -1 0 0X48 1 0 0 1 \"\"HOTAS-DMS Up\"\"\r\nSimDMSDown -1 0 0X50 1 0 0 1 \"\"HOTAS-DMS Down\"\"\r\nSimDMSLeft -1 0 0X4B 1 0 0 1 \"\"HOTAS-DMS Left\"\"\r\nSimDMSRight -1 0 0X4D 1 0 0 1 \"\"HOTAS-DMS Right\"\"\r\nSimAVTRSwitch -1 0 0X21 4 0 0 1 \"\"Ckpit-AVTR Switch\"\"\r\nSimAVTRSwitchBack -1 0 0XFFFFFFFF 0 0 0 1 \"\"Ckpit-AVTR Switch back\"\"\r\nSimINSInc 1168 0 0X42 6 0 0 1 \"\"Ckpit-INS Inc\"\"\r\nSimINSDec 1168 0 0X41 6 0 0 1 \"\"Ckpit-INS Dec\"\"\r\nSimMalIndLights 1086 0 0X14 2 0 0 1 \"\"Lights-Test\"\"\r\nSimLEFLockSwitch 1133 0 0X6 2 0 0 1 \"\"Flaps-Lock LEFs\"\"\r\nSimTrimAPDisc 1174 0 0X5 2 0 0 1 \"\"Trim-AP Disc\"\"\r\nSimTrimNoseUp -1 0 0XC7 5 0 0 1 \"\"Trim-Manual nose up\"\"\r\nSimTrimNoseDown -1 0 0XCF 5 0 0 1 \"\"Trim-Manual nose down\"\"\r\nSimTrimYawLeft -1 0 0XD2 5 0 0 1 \"\"Trim-Manual yaw Left\"\"\r\nSimTrimYawRight -1 0 0XC9 5 0 0 1 \"\"Trim-Manual yaw right\"\"\r\nSimTrimRollLeft -1 0 0XD3 5 0 0 1 \"\"Trim-Manual roll left\"\"\r\nSimTrimRollRight -1 0 0XD1 5 0 0 1 \"\"Trim-Manual roll right\"\"\r\nSimStepMissileVolumeDown 1179 0 0X1A 3 0 0 1 \"\"Sound-Missile Volume Down\"\"\r\nSimStepMissileVolumeUp 1179 0 0X1B 3 0 0 1 \"\"Sound-Missile Volume up\"\"\r\nSimStepThreatVolumeDown 1180 0 0X1A 5 0 0 1 \"\"Sound-Threat Volume Down\"\"\r\nSimStepThreatVolumeUp 1180 0 0X1B 5 0 0 1 \"\"Sound-Threat Volume up\"\"\r\nSimStepComm1VolumeDown 1182 0 0X1A 6 0 0 1 \"\"Comm-1 Volume Down\"\"\r\nSimStepComm1VolumeUp 1182 0 0X1B 6 0 0 1 \"\"Comm-1 Volume up\"\"\r\nSimStepComm2VolumeDown 1183 0 0X1A 7 0 0 1 \"\"Comm-2 Volume Down\"\"\r\nSimStepComm2VolumeUp 1183 0 0X1B 7 0 0 1 \"\"Comm-2 Volume up\"\"\r\nSimTriggerFirstDetent -1 0 0X35 2 0 0 1 \"\"HOTAS-First Trigger Detent\"\"\r\nSimTriggerSecondDetent -1 0 0X35 4 0 0 1 \"\"HOTAS-Second Trigger Detent\"\"\r\nAFFullFlap -1 0 0X44 2 0 0 1 \"\"Flaps-Set to Full\"\"\r\nAFNoFlap -1 0 0X43 2 0 0 1 \"\"Flaps-Set to Null\"\"\r\nAFIncFlap -1 0 0X58 2 0 0 1 \"\"Flaps-Increase\"\"\r\nAFDecFlap -1 0 0X57 2 0 0 1 \"\"Flaps-Decrease\"\"\r\nAFFullLEF -1 0 0X44 4 0 0 1 \"\"Flaps-Set LEF to Full\"\"\r\nAFNoLEF -1 0 0X43 4 0 0 1 \"\"Flaps-Set LEF to Null\"\"\r\nAFIncLEF -1 0 0X58 4 0 0 1 \"\"Flaps-Increase LEF\"\"\r\nAFDecLEF -1 0 0X57 4 0 0 1 \"\"Flaps-Decrease LEF\"\"\r\nSimRetUp -1 0 0X1B 2 0 0 1 \"\"HUD-Man.Bomb Reticle Up\"\"\r\nSimRetDn -1 0 0X1A 2 0 0 1 \"\"HUD-Man.Bomb Reticle Down\"\"\r\nAFDragChute -1 0 0X20 1 0 0 1 \"\"Ckpit-Deploy Drag Chute\"\"\r\nAFCanopyToggle -1 0 0X2E 3 0 0 1 \"\"Ckpit-Open/Close canopy\"\"\r\nFACIn -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-In\"\"\r\nFACOut -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-Out\"\"\r\nFACCheckIn -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-Check In\"\"\r\nFACCheckOut -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-Check Out\"\"\r\nFACRequestTarget -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-Request Target\"\"\r\nFACRequestBDA -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-Request BDA\"\"\r\nFACWilco -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-Wilco\"\"\r\nFACUnable -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-Unable\"\"\r\nFACReady -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-Ready\"\"\r\nFACRequestMark -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-Request Mark\"\"\r\nFACRequestLocation -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-Request Location\"\"\r\nFACRequestTACAN -1 0 0XFFFFFFFF 0 0 0 1 \"\"FAC-Request TACAN\"\"\r\nSimMouseLook -1 0 0XFFFFFFFF 0 0 0 1 \"\"View-Mouse Look Hold\"\"\r\nSimMouseLookOn -1 0 0XFFFFFFFF 0 0 0 1 \"\"View-Mouse Look On\"\"\r\nSimMouseLookOff -1 0 0XFFFFFFFF 0 0 0 1 \"\"View-Mouse Look Off\"\"\r\nSimMouseLookToggle -1 0 0XFFFFFFFF 0 0 0 1 \"\"View-Mouse Look Toggle\"\"\r\nSimMouseSOI -1 0 0XFFFFFFFF 0 0 0 1 \"\"Sim-Mouse SOI Hold\"\"\r\nSimMouseSOIOn -1 0 0X1A 4 0 0 1 \"\"Sim-Mouse SOI On\"\"\r\nSimMouseSOIOff -1 0 0X1B 4 0 0 1 \"\"Sim-Mouse SOI Off\"\"\r\nSimMouseSOIToggle -1 0 0XFFFFFFFF 0 0 0 1 \"\"Sim-Mouse SOI Toggle\"\"\r\nSimMouseButton1 -1 0 0X10 4 0 0 1 \"\"Sim-Mouse Button 1\"\"\r\nSimMouseButton2 -1 0 0X11 4 0 0 1 \"\"Sim-Mouse Button 2\"\"\r\nCalibrateJoystick -1 0 0X24 0 0X2E 4 -1 \"\"Sim-Calibrate Joystick\"\"\r\nSetABDetent -1 0 0X25 0 0X2E 4 -1 \"\"Sim-Set AB Detent\"\"\r\nSimResetTrackIR -1 0 0X14 0 0X2E 4 -1 \"\"Sim-Reset TrackIR\"\"\r\nSimAltFlaps 1175 0 0XFFFFFFFF 0 0 0 1 \"\"Flaps-LE Normal/Extend\"\"\r\nSimIFFPower 1170 0 0XFFFFFFFF 0 0 0 1 \"\"Ckpit-IFF Master\"\"\r\nSimRwrPower 1096 0 0XFFFFFFFF 0 0 0 1 \"\"RWR-Power\"\"\r\nSimSymWheelDn 1184 0 0XFFFFFFFF 0 0 0 1 \"\"ICP-Sym Wheel Down\"\"\r\nSimSymWheelUp 1184 0 0XFFFFFFFF 0 0 0 1 \"\"ICP-Sym Wheel Up\"\"\r\nSimInteriorLight 1146 0 0XFFFFFFFF 0 0 0 1 \"\"Lights-Interior Lights\"\"\r\nToggleLandingHelpMode -1 0 0X23 4 0 0 1 \"\"Landing Help Toggle\"\"\r\nSimRadarNextEnemy -1 0 0XFFFFFFFF 0 0 0 1 \"\"Easy Radar-Next Enemy\"\"\r\nSimRadarPreviousEnemy -1 0 0X12 1 0 0 1 \"\"Easy Radar-Previous Enemy\"\"\r\nSimRadarClosestEnemy -1 0 0XFFFFFFFF 0 0 0 1 \"\"Easy Radar-Closest Enemy\"\"\r\nSimRadarBoresightEnemy -1 0 0X13 1 0 0 1 \"\"Easy Radar-Boresight Enemy\"\"\r\nSimRadarNextFriendly -1 0 0XFFFFFFFF 0 0 0 1 \"\"Easy Radar-Next Friendly\"\"\r\nSimRadarPreviousFriendly -1 0 0X14 1 0 0 1 \"\"Easy Radar-Previous Friendly\"\"\r\nSimRadarClosestFriendly -1 0 0XFFFFFFFF 0 0 0 1 \"\"Easy Radar-Closest Friendly\"\"\r\nSimRadarBoresightFriendly -1 0 0X15 1 0 0 1 \"\"Easy Radar-Boresight Friendly\"\"\r\nSimTransmitCom1 -1 0 0X2 4 0 0 1 \"\"Voice-Transmit Com1\"\"\r\nSimTransmitCom2 -1 0 0X3 4 0 0 1 \"\"Voice-Transmit Com2\"\"\r\nOTWToggleFrameRate -1 0 0X13 0 0X2C 2 -2 \"\"Sim-Display frame rate\"\"\r\nOTWToggleAeroDisplay -1 0 0X18 0 0X2C 2 -2 \"\"Sim-Aerodynamic Debug\"\"\r\nRadioMessageSend -1 0 0XF 0 0XFFFFFFFF 0 -2 \"\"Radio-send message\"\"\r\nOTWRadioMenuStep -1 0 0XF 0 0XF 1 -2 \"\"Radio-next menu\"\"\r\nOTWRadioMenuStep -1 0 0XF 0 0XF 0 -2 \"\"Radio-next menu\"\"\r\nOTWRadioMenuStepBack -1 0 0XF 1 0XF 1 -2 \"\"Radio-previous menu\"\"\r\nOTWRadioMenuStepBack -1 0 0XF 1 0XF 0 -2 \"\"Radio-previous menu\"\"\r\nRadioMessageSend -1 0 0X10 0 0XFFFFFFFF 0 -2 \"\"Radio-send message\"\"\r\nOTWRadioMenuStep -1 0 0X10 0 0X10 1 -2 \"\"Radio-next menu\"\"\r\nOTWRadioMenuStep -1 0 0X10 0 0X10 0 -2 \"\"Radio-next menu\"\"\r\nOTWRadioMenuStepBack -1 0 0X10 1 0X10 1 -2 \"\"Radio-previous menu\"\"\r\nOTWRadioMenuStepBack -1 0 0X10 1 0X10 0 -2 \"\"Radio-previous menu\"\"\r\nRadioMessageSend -1 0 0X11 0 0XFFFFFFFF 0 -2 \"\"Radio-send message\"\"\r\nOTWRadioMenuStep -1 0 0X11 0 0X11 0 -2 \"\"Radio-next menu\"\"\r\nOTWRadioMenuStep -1 0 0X11 0 0X11 1 -2 \"\"Radio-next menu\"\"\r\nOTWRadioMenuStepBack -1 0 0X11 1 0X11 1 -2 \"\"Radio-previous menu\"\"\r\nOTWRadioMenuStepBack -1 0 0X11 1 0X11 0 -2 \"\"Radio-previous menu\"\"\r\nRadioMessageSend -1 0 0X12 0 0XFFFFFFFF 0 -2 \"\"Radio-send message\"\"\r\nOTWRadioMenuStep -1 0 0X12 0 0X12 0 -2 \"\"Radio-next menu\"\"\r\nOTWRadioMenuStep -1 0 0X12 0 0X12 1 -2 \"\"Radio-next menu\"\"\r\nOTWRadioMenuStepBack -1 0 0X12 1 0X12 0 -2 \"\"Radio-previous menu\"\"\r\nOTWRadioMenuStepBack -1 0 0X12 1 0X12 1 -2 \"\"Radio-previous menu\"\"\r\nRadioMessageSend -1 0 0X13 0 0XFFFFFFFF 0 -2 \"\"Radio-send message\"\"\r\nOTWRadioMenuStep -1 0 0X13 0 0X13 1 -2 \"\"Radio-next menu\"\"\r\nOTWRadioMenuStep -1 0 0X13 0 0X13 0 -2 \"\"Radio-next menu\"\"\r\nOTWRadioMenuStepBack -1 0 0X13 1 0X13 0 -2 \"\"Radio-previous menu\"\"\r\nOTWRadioMenuStepBack -1 0 0X13 1 0X13 1 -2 \"\"Radio-previous menu\"\"\r\nRadioMessageSend -1 0 0X14 0 0XFFFFFFFF 0 -2 \"\"Radio-send message\"\"\r\nRadioMessageSend -1 0 0X15 0 0XFFFFFFFF 0 -2 \"\"Radio-send message\"\"\r\nOTWSetScale -1 0 0XFFFFFFFF 0 0 0 -2 \"\"Sim-BSS=1\"\" \r\nOTWSetScale -1 0 0XFFFFFFFF 0 0 0 -2 \"\"Sim-BSS=3\"\" \r\nOTWSetScale -1 0 0XFFFFFFFF 0 0 0 -2 \"\"Sim-BSS=5\"\" \r\nOTWSetScale -1 0 0XFFFFFFFF 0 0 0 -2 \"\"Sim-BSS=7\"\" \r\nOTWSetScale -1 0 0XFFFFFFFF 0 0 0 -2 \"\"Sim-BSS=9\"\" \r\nOTWSetScale -1 0 0XFFFFFFFF 0 0 0 -2 \"\"Sim-BSS=11\"\" \r\nOTWSetScale -1 0 0XFFFFFFFF 0 0 0 -2 \"\"Sim-BSS=13\"\" \r\nOTWSetScale -1 0 0XFFFFFFFF 0 0 0 -2 \"\"Sim-BSS=15\"\" \r\nOTWSetScale -1 0 0XFFFFFFFF 0 0 0 -2 \"\"Sim-BSS=17\"\"\r\nOTWScaleDown -1 0 0XD1 4 0 0 -2 \"\"Sim-object scale down\"\"\r\nOTWScaleUp -1 0 0XC9 4 0 0 -2 \"\"Sim-object scale up\"\"\r\nOTWStateStep -1 0 0X39 1 0 0 -2 \"\"Sim-cycle object states\"\"\r\nOTWToggleAutoScale -1 0 0XB 0 0X2D 2 -2 \"\"Sim-vehicle auto-scaling\"\"\r\nOTWSetObjDetail -1 0 0X2 2 0X2D 2 -2 \"\"Sim-Set object density\"\"\r\nOTWSetObjDetail -1 0 0X3 2 0X2D 2 -2 \"\"Sim-Set object density\"\"\r\nOTWSetObjDetail -1 0 0X4 2 0X2D 2 -2 \"\"Sim-Set object density\"\"\r\nOTWSetObjDetail -1 0 0X5 2 0X2D 2 -2 \"\"Sim-Set object density\"\"\r\nOTWSetObjDetail -1 0 0X6 2 0X2D 2 -2 \"\"Sim-Set object density\"\"\r\nOTWToggleAlpha -1 0 0X1E 0 0X2D 2 -2 \"\"Sim-alpha blending\"\"\r\nOTWToggleBilinearFilter -1 0 0X30 0 0X2D 2 -2 \"\"Sim-Bilinear filtering\"\"\r\nOTWToggleGLOC -1 0 0X30 0 0X2C 2 -2 \"\"Sim-Blackout/Redout\"\"\r\nOTWEnterPosition -1 0 0X2E 0 0X2C 2 -2 \"\"Sim-Move to coordinates\"\"\r\nOTWToggleEyeFly -1 0 0X21 0 0X2C 2 -2 \"\"Sim-Testing function\"\"\r\nOTWToggleShading -1 0 0X22 0 0X2D 2 -2 \"\"Sim-Terrain shading\"\"\r\nOTWToggleHaze -1 0 0X23 0 0X2D 2 -2 \"\"Sim-Haze\"\"\r\nKevinsFistOfGod -1 0 0X25 0 0X2C 2 -2 \"\"Sim-Fist of God\"\"\r\nOTWToggleLocationDisplay -1 0 0X26 0 0X2C 2 -2 \"\"Sim-World Location\"\"\r\nSimStepSMSRight -1 0 0X34 5 0 0 -2 \"\"Sim-Time of day\"\"\r\nOTWToggleRoof -1 0 0X13 0 0X2D 2 -2 \"\"Sim-Cloud roof\"\"\r\nOTWTextureDecrease -1 0 0X14 3 0 0 -2 \"\"Sim-texture distance dec\"\"\r\nOTWTextureIncrease -1 0 0X14 5 0 0 -2 \"\"Sim-texture distance inc\"\"\r\nOTWToggleClouds -1 0 0X11 0 0X2D 2 -2 \"\"Sim-clouds\"\"\r\nSimToggleInvincible -1 0 0X2C 0 0X2C 2 -2 \"\"Sim-invincibility\"\"\r\nOTWToggleStatusLine -1 0 0X1F 0 0X2C 2 -2 \"\"Sim-Status Line\"\"\r\nSimTrigger 0 -1 -2 0 0x0 0\r\nSimPickle 1 -1 -2 0 0x0 0\r\nSimDesignate 2 -1 -2 0 0x0 0\r\nSimDropTrack 3 -1 -2 0 0x0 0\r\nSimNextAAWeapon 4 1013 -2 0 0x0 0\r\nSimNextAGWeapon 5 1014 -2 0 0x0 0\r\nSimNextNavMode 6 1012 -2 0 0x0 0\r\nSimFCCSubModeStep 7 -1 -2 0 0x0 0\r\n";

        var keyValuePairsModifiers = new Dictionary<string, string>
        {
            ["0"] = "",
            ["1"] = "Shift",
            ["2"] = "Ctrl",
            ["3"] = "Shift + Ctrl",
            ["4"] = "Alt",
            ["5"] = "Shift + Alt",
            ["6"] = "Ctrl + Alt",
            ["7"] = "Shift + Ctrl + Alt"
        };

        var keyValuePairsKeys = new Dictionary<string, string>
        {
            ["0X1"] = "ESC",

            ["0X3B"] = "F1",
            ["0X3C"] = "F2",
            ["0X3D"] = "F3",
            ["0X3E"] = "F4",

            ["0X3F"] = "F5",
            ["0X40"] = "F6",
            ["0X41"] = "F7",
            ["0X42"] = "F8",

            ["0X43"] = "F9",
            ["0X44"] = "F10",
            ["0X57"] = "F11",
            ["0X58"] = "F12",

            ["0XB7"] = "Print-Scr",
            ["0X46"] = "Scroll-Lock",

            ["0X29"] = "`",
            ["0X2"] = "1",
            ["0X3"] = "2",
            ["0X4"] = "3",
            ["0X5"] = "4",
            ["0X6"] = "5",
            ["0X7"] = "6",
            ["0X8"] = "7",
            ["0X9"] = "8",
            ["0XA"] = "9",
            ["0XB"] = "0",
            ["0XC"] = "-",
            ["0XD"] = "=",
            ["0XE"] = "Backspace",

            ["0XF"] = "TAB",
            ["0X10"] = "Q",
            ["0X11"] = "W",
            ["0X12"] = "E",
            ["0X13"] = "R",
            ["0X14"] = "T",
            ["0X15"] = "Y",
            ["0X16"] = "U",
            ["0X17"] = "I",
            ["0X18"] = "O",
            ["0X19"] = "P",
            ["0X1A"] = "[",
            ["0X1B"] = "]",
            ["0X2B"] = @"\",

            ["0X3A"] = "Caps-Lock",
            ["0X1E"] = "A",
            ["0X1F"] = "S",
            ["0X20"] = "D",
            ["0X21"] = "F",
            ["0X22"] = "G",
            ["0X23"] = "H",
            ["0X24"] = "J",
            ["0X25"] = "K",
            ["0X26"] = "L",
            ["0X27"] = ";",
            ["0X28"] = "'",
            ["0X1C"] = "Enter",

            ["0X2C"] = "Z",
            ["0X2D"] = "X",
            ["0X2E"] = "C",
            ["0X2F"] = "V",
            ["0X30"] = "B",
            ["0X31"] = "N",
            ["0X32"] = "M",
            ["0X33"] = ",",
            ["0X34"] = ".",
            ["0X35"] = "/",

            ["0X39"] = "Space",

            ["0XD2"] = "Ins",
            ["0XC7"] = "Home",
            ["0XC9"] = "Pg Up",
            ["0XD3"] = "Del",
            ["0XCF"] = "End",
            ["0XD1"] = "Pg Dn",

            ["0XC8"] = "Up",
            ["0XCB"] = "Left",
            ["0XD0"] = "Down",
            ["0XCD"] = "Right",

            ["0X45"] = "Num-Lock",
            ["0XB5"] = "Num /",
            ["0X37"] = "Num *",
            ["0X4A"] = "Num -",

            ["0X47"] = "Num 7",
            ["0X48"] = "Num 8",
            ["0X49"] = "Num 9",
            ["0X4B"] = "Num 4",
            ["0X4C"] = "Num 5",
            ["0X4D"] = "Num 6",
            ["0X4F"] = "Num 1",
            ["0X50"] = "Num 2",
            ["0X51"] = "Num 3",
            ["0X52"] = "Num 0",
            ["0X53"] = "Num ,",

            ["0X4E"] = "Num +",
            ["0X9C"] = "Num Enter",
            ["0X4E"] = "Num +",

            ["0XFFFFFFFF"] = "-",
        };


        string[] keyfileSplitted = keyfile.Split(new string[] { "\r\n" }, StringSplitOptions.None);
        var matrixSize = keyfileSplitted.Length;

        string[][] keys = new string[matrixSize][];

        var i = 0;
        foreach (string line in keyfileSplitted)
        {
            var newLine = line.Split(new string[] { " " }, StringSplitOptions.None);
            var newLineLength = newLine.Length;

            if (newLineLength <= 9)
            {
                keys[i] = newLine;
            }
            else
            {
                var newerLine = new string[9];

                int j;

                for (j = 0; j < 9; j++)
                {
                    newerLine[j] = newLine[j];
                }

                string aux = "";

                for (; j < newLineLength; j++)
                {
                    aux += " " + newLine[j];
                }

                aux = aux.Substring(1, aux.Length - 1);

                newerLine[8] += aux;

                keys[i] = newerLine;
            }

            i++;
        }

        ////PRINTING


        foreach (string[] line in keys)
        {
            var length = line.Length;

            var aux1 = "";
            var aux2 = "";

            if (length == 9)
            {
                
                if (line[4] != "0")
                {
                    aux1 += keyValuePairsModifiers[line[4]] + " + ";
                }

                aux1 += keyValuePairsKeys[line[3]];

                aux2 = line[8];

                PrettyPrint(aux1, aux2, 27);
            }
        }
    }

    public static void PrettyPrint(string a, string b, int space)
    {
        int aLen = a.Length;
        

        b = b.Substring(2, b.Length - 4);

        Console.Write(a);

        for (int i = 0; i < space - aLen; i++)
        {
            Console.Write(" ");
        }
        Console.Write(b);
        Console.WriteLine();
    }
}

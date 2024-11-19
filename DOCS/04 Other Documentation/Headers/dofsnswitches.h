#ifndef _DOFS_N_SWITCHES_H_
#define _DOFS_N_SWITCHES_H_

enum Switches{
	COMP_AB				= 0,

	/* MLR 2/22/2004 - Do not use these ID's in the code anymore, use the arrays at the bottom of this file 
	COMP_NOS_GEAR_SW	= 1,
	COMP_LT_GEAR_SW		= 2,
	COMP_RT_GEAR_SW		= 3,
	*/

	/* MLR 2/22/2004 - Do not use these ID's in the code anymore, use the arrays at the bottom of this file */
	COMP_GEAR_SW_1		= 1,
	COMP_GEAR_SW_2		= 2,
	COMP_GEAR_SW_3		= 3,

	COMP_NOS_GEAR_ROD	= 4,
	COMP_CANOPY			= 5,
	COMP_WING_VAPOR		= 6,
	COMP_TAIL_STROBE	= 7,
	COMP_NAV_LIGHTS		= 47, // for Mav: MD -- 20090317: flip these over to separate them
	COMP_NAV_LIGHTSFLASH = 8,
	COMP_LAND_LIGHTS	= 9,
	COMP_EXH_NOZZLE		= 10,
	/*
	COMP_TIRN_POD		= 11,
	COMP_HTS_POD		= 12,*/
	COMP_REFUEL_DR		= 13,

	/* MLR 2/22/2004 - Do not use these ID's in the code anymore, use the arrays at the bottom of this file 
	COMP_NOS_GEAR_DR_SW	= 14,
	COMP_LT_GEAR_DR_SW	= 15,
	COMP_RT_GEAR_DR_SW	= 16,
	COMP_NOS_GEAR_HOLE	= 17,
	COMP_LT_GEAR_HOLE	= 18,
	COMP_RT_GEAR_HOLE	= 19,
	*/

	/* MLR 2/22/2004 - Do not use these ID's in the code anymore, use the arrays at the bottom of this file */
	COMP_GEAR_DR_SW_1	= 14,
	COMP_GEAR_DR_SW_2	= 15,
	COMP_GEAR_DR_SW_3	= 16,
	COMP_GEAR_HOLE_1	= 17,
	COMP_GEAR_HOLE_2	= 18,
	COMP_GEAR_HOLE_3	= 19,

	/* MLR 2/22/2004 - Do not use these ID's in the code anymore, use the arrays at the bottom of this file 
	COMP_BROKEN_NOS_GEAR_SW= 20,
	COMP_BROKEN_LT_GEAR_SW = 21,
	COMP_BROKEN_RT_GEAR_SW = 22,
	*/

	/* MLR 2/22/2004 - Do not use these ID's in the code anymore, use the arrays at the bottom of this file */
	COMP_GEAR_BROKEN_SW_1 = 20,
	COMP_GEAR_BROKEN_SW_2 = 21,
	COMP_GEAR_BROKEN_SW_3 = 22,

	COMP_HOOK		= 23,
	COMP_DRAGCHUTE		= 24, // landing drag chute

	// MLR 2003-10-05 
	COMP_PIT_AB				= 25, // these are reserved for the 3d pits
	COMP_PIT_NOS_GEAR_SW	= 26, // since the 1st 4 switches & #7 are used by pit specific data,
	COMP_PIT_LT_GEAR_SW		= 27, // these are set to be equal to dofs 0 - 3
	COMP_PIT_RT_GEAR_SW		= 28, //
	COMP_PIT_TAIL_STROBE    = 29,
	COMP_AB2				= 30,
	COMP_EXH_NOZZLE2		= 31,

	/* Do not use these ID's in the code anymore, use the arrays at the bottom of this file */
	COMP_GEAR_SW_4	= 32,
	COMP_GEAR_SW_5	= 33,
	COMP_GEAR_SW_6	= 34,
	COMP_GEAR_SW_7	= 35,
	COMP_GEAR_SW_8	= 36,

	/* Do not use these ID's in the code anymore, use the arrays at the bottom of this file */
	COMP_GEAR_DR_SW_4	= 37,
	COMP_GEAR_DR_SW_5	= 38,
	COMP_GEAR_DR_SW_6	= 39,
	COMP_GEAR_DR_SW_7	= 40,
	COMP_GEAR_DR_SW_8	= 41,

	/* Do not use these ID's in the code anymore, use the arrays at the bottom of this file */
	COMP_GEAR_HOLE_4	= 42,
	COMP_GEAR_HOLE_5	= 43,
	COMP_GEAR_HOLE_6	= 44,
	COMP_GEAR_HOLE_7	= 45,
	COMP_GEAR_HOLE_8	= 46,



	/* Do not use these ID's in the code anymore, use the arrays at the bottom of this file */
	COMP_GEAR_BROKEN_SW_4 = 48,
	COMP_GEAR_BROKEN_SW_5 = 49,
	COMP_GEAR_BROKEN_SW_6 = 50,
	COMP_GEAR_BROKEN_SW_7 = 51,
	COMP_GEAR_BROKEN_SW_8 = 52,

	COMP_WEAPON_BAY_0_SW = 53,
	COMP_WEAPON_BAY_1_SW = 54,
	COMP_WEAPON_BAY_2_SW = 55,
	COMP_WEAPON_BAY_3_SW = 56,
	COMP_WEAPON_BAY_4_SW = 57,

	COMP_TANKER_LIGHTS_1 = 58,
	COMP_TANKER_LIGHTS_2 = 59,

	COMP_CHOCKS = 60, //ATARIBABY 17032009 undercarrige chocks in AC model 
	COMP_FLIGHT_NUMBER_DECAL = 61, //ATARIBABY 08022010 decal switch reflects AC position in flight 

	COMP_FORMATION_LIGHTS = 62, // Switch to adjust dimming level of formation lights

	COMP_NAVAL_GOODIES = 63, // Switch to adjust dimming level of formation lights

	COMP_WINGTIP_RAIL_L = 64, //JP very specific to make appear /disappear Wingtip rails  when necessary (eg SU33  the rails are always there even if no weapon, except they are removed for ECM PODS )

	COMP_WINGTIP_RAIL_R = 65, // JP very specific to make appear / disappear Wingtip rails when necessary (eg SU33  the rails are always there even if no weapon, except they are removed for ECM PODS )

	COMP_MAX_SWITCH		= 66,	// update!

	//ATARIBABY start new 3d cokpit switches, i made enought hole i hope
	COMP_3DPIT_BACKUP_ADI_OFFMARK = 100, //Backup OFF flag - only visible on ramp-start with cold jet
	COMP_3DPIT_ARNWS_LIGHT = 101, //AR/NWS console NWS light
	COMP_3DPIT_ARRDY_LIGHT = 102, //AR/NWS console RDY light
	COMP_3DPIT_ARDISC_LIGHT = 103, //AR/NWS console DISC light
	COMP_3DPIT_AOAON_LIGHT = 104, //AOA indexer console ON light
	COMP_3DPIT_AOABELOW_LIGHT = 105, //AOA indexer console bellow light
	COMP_3DPIT_AOAABOVE_LIGHT = 106, //AOA indexer console above light
	COMP_3DPIT_ALTPNEU_FLAG = 107, //ALT instrumnet PNEU flag
	COMP_3DPIT_ILS_VISIBLE = 108, //Make ILS needles on main ADI hide/show
	COMP_3DPIT_EYEBROW_ENGFIRE = 109, //RIGHT EYEBROW caution light ENG FIRE
	COMP_3DPIT_EYEBROW_ENGINE = 110, //RIGHT EYEBROW caution light ENGINE
	COMP_3DPIT_EYEBROW_HYDOIL = 111, //RIGHT EYEBROW caution light HYD/OIL PRESS
	COMP_3DPIT_EYEBROW_FLCS = 112, //RIGHT EYEBROW caution light FLCS
	COMP_3DPIT_EYEBROW_TOLDG = 113, //RIGHT EYEBROW caution light TO/LDG CONFIG
	COMP_3DPIT_EYEBROW_CANOPY = 114, //RIGHT EYEBROW caution light CANOPY
	COMP_3DPIT_EYEBROW_TFFAIL = 115, //LEFT EYEBROW caution light TR-FAIL
	COMP_3DPIT_ADI_LOC_FLAG = 116, //MAIN ADI LOC flag
	COMP_3DPIT_ADI_GS_FLAG = 117, //MAIN ADI GS flag
	COMP_3DPIT_ADI_OFF_FLAG = 118, //MAIN ADI OFF flag
	COMP_3DPIT_ADI_AUX_FLAG = 119, //MAIN ADI AUX flag
	COMP_3DPIT_HSI_OFF_FLAG = 120, //HSI OFF flag
	COMP_3DPIT_HSI_TO_FLAG = 121, //HSI TO flag
	COMP_3DPIT_HSI_FROM_FLAG = 122, //HSI FROM flag
	COMP_3DPIT_HSI_ILSWARN_FLAG = 123, //HSI ILSWARN flag
	COMP_3DPIT_HSI_CRSWARN_FLAG = 124, //HSI CRSWARN flag
	COMP_3DPIT_AOA_OFF_FLAG = 125, //AOA OFF flag
	COMP_3DPIT_VVI_OFF_FLAG = 126, //VVI OFF flag
	COMP_3DPIT_GEAR_HANDLE_LIGHT = 127, //Gear handle trans light
	COMP_3DPIT_CANOPY_LOCKS = 128, //Canopy locks
	COMP_3DPIT_EMER_JETTISON = 129, //Emergency jettison button
	COMP_3DPIT_ALT_GEAR = 130, //Alt gear handle
	COMP_3DPIT_GEAR_LIGHT1= 131, //Nose gear light
	COMP_3DPIT_GEAR_LIGHT2= 132, //Main left gear light
	COMP_3DPIT_GEAR_LIGHT3= 133, //Main right gear light
	COMP_3DPIT_ICP_DCS= 134, //ICP DATA COMMAND switch
	COMP_3DPIT_ICP_DRIFTCO= 135, //ICP DRIFT CUTOFF switch
	COMP_3DPIT_ICP_NEXTPREV= 136, //ICP NEXTPREV switch
	COMP_3DPIT_JFS= 137, //JFS switch
	COMP_3DPIT_JSF_LIGHT= 138, //JFS light
	COMP_3DPIT_MPO= 139, //MPO switch
	COMP_3DPIT_EPU_LIGHT= 140, //EPU light
	COMP_3DPIT_EPU_AIR_LIGHT= 141, //EPU AIR light
	COMP_3DPIT_EPU_HYD_LIGHT= 142, //EPU HYDRAZINE light
	COMP_3DPIT_ELEC_FLCSPMG_LIGHT= 143, //ELEC FlcsPmg light
	COMP_3DPIT_ELEC_MAINGEN_LIGHT= 144, //ELEC MainGen light
	COMP_3DPIT_ELEC_STBYGEN_LIGHT= 145, //ELEC StbyGen light
	COMP_3DPIT_ELEC_EPUGEN_LIGHT= 146, //ELEC EpuGen light
	COMP_3DPIT_ELEC_EPUPMG_LIGHT= 147, //ELEC EpuPmg light
	COMP_3DPIT_ELEC_FLCSRLY_LIGHT= 148, //ELEC FlcsRly light
	COMP_3DPIT_ELEC_TOFLCS_LIGHT= 149, //ELEC ToFlcs light
	COMP_3DPIT_ELEC_BATFAIL_LIGHT= 150, //ELEC BatFail light	
	COMP_3DPIT_ELEC_MAIN= 151, //ELEC Main Power switch
	COMP_3DPIT_EPU= 152, //EPU switch
	COMP_3DPIT_CAUTION_FLCS_FAULT=153, //Caution panel FLCS FAULT light
	COMP_3DPIT_CAUTION_ELEC_SYS=154, //Caution panel ELEC SYS light
	COMP_3DPIT_CAUTION_PROBE_HEAT=155, //Caution panel PROBE HEAT light
	COMP_3DPIT_CAUTION_CADC=156, //Caution panel CADC light
	COMP_3DPIT_CAUTION_STORES_CONFIG=157, //Caution panel STORES CONFIG light
	COMP_3DPIT_CAUTION_FWD_FUEL_LOW=158, //Caution panel FWD FUEL LOW light
	COMP_3DPIT_CAUTION_AFT_FUEL_LOW=159, //Caution panel AFT FUEL LOW light
	COMP_3DPIT_CAUTION_ENGINE_FAULT=160, //Caution panel ENGINE FAULT light
	COMP_3DPIT_CAUTION_SEC=161, //Caution panel SEC light
	COMP_3DPIT_CAUTION_FUEL_OIL_HOT=162, //Caution panel FUEL OIL HOT light
	COMP_3DPIT_CAUTION_OVERHEAT=163, //Caution panel OVERHEAT light
	COMP_3DPIT_CAUTION_BUC=164, //Caution panel BUC light
	COMP_3DPIT_CAUTION_AVIONICS_FAULT=165, //Caution panel AVIONICS FAULT light
	COMP_3DPIT_CAUTION_RADAR_ALT=166, //Caution panel RADAR ALT light
	COMP_3DPIT_CAUTION_IFF=167, //Caution panel IFF light
	COMP_3DPIT_CAUTION_SEAT_NOT_ARMED=168, //Caution panel SEAT NOT ARMED light
	COMP_3DPIT_CAUTION_NWS_FAIL=169, //Caution panel NWS FAIL light
	COMP_3DPIT_CAUTION_ANTI_SKID=170, //Caution panel ANTI SKID light
	COMP_3DPIT_CAUTION_HOOK=171, //Caution panel HOOK light
	COMP_3DPIT_CAUTION_OXY_LOW=172, //Caution panel OXY_LOW light
	COMP_3DPIT_CAUTION_CABIN_PRESS=173, //Caution panel CABIN PRESS light
	COMP_3DPIT_TEST=174, //TEST for bogus unimplemented lights
	COMP_3DPIT_INSTLIGHT=175, //Instruments light
	COMP_3DPIT_TWS_LAUNCH=176, //Threat Warning Prime Launch
	COMP_3DPIT_TWS_PRIMODE=177, //Threat Warning Prime PriMode
	COMP_3DPIT_TWS_OPENMODE=178, //Threat Warning Prime OpenMode
	COMP_3DPIT_TWS_HANDOFF=179, //Threat Warning Prime HandOff
	COMP_3DPIT_TWS_TGTSEP=180, //Threat Warning Prime TgtSep
	COMP_3DPIT_TWS_U=181, //Threat Warning Prime U
	COMP_3DPIT_TWS_NAVAL=182, //Threat Warning Prime Naval
	COMP_3DPIT_TWS_UNK=183, //Threat Warning Prime Unknown
	COMP_3DPIT_TWS_SYSTESTON=184, //Threat Warning Prime SysTestOn
	COMP_3DPIT_TWS_AUXSRCH=185, //Threat Warning AuxSrch
	COMP_3DPIT_TWS_AUXACT=186, //Threat Warning AuxAct
	COMP_3DPIT_TWS_AUXLOW=187, //Threat Warning AuxLow
	COMP_3DPIT_TWS_AUXSYSTEM=188, //Threat Warning AuxSystem
	COMP_3DPIT_TWS_RWSHAVEPWR=189, //RWS have pwr
	COMP_3DPIT_ECMPWR=190, //EcmPwr
	COMP_3DPIT_ECMFAIL=191, //EcmFail
	COMP_3DPIT_TFR_STBY=192, //TFR_STBY
	COMP_3DPIT_TFR_ENGAGED=193, //TFR_ENGAGED
	COMP_3DPIT_AVTR=194, //AVTR
	COMP_3DPIT_OUTERMARKER=195, //OuterMarker
	COMP_3DPIT_MIDDLEMARKER=196, //MiddleMarker
	COMP_3DPIT_CMDS_FLARE_DIGIT1=197, //CMDS FLARE COUNT digit 1
	COMP_3DPIT_CMDS_FLARE_DIGIT2=198, //CMDS FLARE COUNT digit 2
	COMP_3DPIT_CMDS_FLARE_DIGIT3=199, //CMDS FLARE COUNT digit 3
	COMP_3DPIT_CMDS_CHAFF_DIGIT1=200, //CMDS CHAFF COUNT digit 1
	COMP_3DPIT_CMDS_CHAFF_DIGIT2=201, //CMDS CHAFF COUNT digit 2
	COMP_3DPIT_CMDS_CHAFF_DIGIT3=202, //CMDS CHAFF COUNT digit 3
	COMP_3DPIT_CMDS_GO=203, //CMDS GO
	COMP_3DPIT_CMDS_NOGO=204, //CMDS NOGO
	COMP_3DPIT_CMDS_DISPENSE_RDY=205, //CMDS DISPENSE RDY
	COMP_3DPIT_OXYGEN_SWITCH=206, //Cockpit oxygen switch
	COMP_3DPIT_CMDS_FLARE_BINGO=207, //CMDS FLARE BINGO
	COMP_3DPIT_CMDS_CHAFF_BINGO=208, //CMDS CHAFF BINGO
	
	//ATARIBABY end
	//JP start
	COMP_3DPIT_209 =209, // SWITCH & KNOBS
	COMP_3DPIT_210 =210, // SWITCH & KNOBS
	COMP_3DPIT_211 =211, // SWITCH & KNOBS
	COMP_3DPIT_212 =212, // SWITCH & KNOBS
	COMP_3DPIT_213 =213, // SWITCH & KNOBS
	COMP_3DPIT_214 =214, // SWITCH & KNOBS
	COMP_3DPIT_217 =217, // SWITCH & KNOBS
	COMP_3DPIT_218 =218, // SWITCH & KNOBS
	COMP_3DPIT_219 =219, // SWITCH & KNOBS
	COMP_3DPIT_220 =220, // SWITCH & KNOBS
	COMP_3DPIT_221 =221, // SWITCH & KNOBS
	COMP_3DPIT_222 =222, // SWITCH & KNOBS
	COMP_3DPIT_223 =223, // SWITCH & KNOBS
	COMP_3DPIT_224 =224, // SWITCH & KNOBS
	COMP_3DPIT_225 =225, // SWITCH & KNOBS
	COMP_3DPIT_226 =226, // SWITCH & KNOBS
	COMP_3DPIT_227 =227, // SWITCH & KNOBS
	COMP_3DPIT_230 =230, // SWITCH & KNOBS // I-Hawk 24/9/09

	COMP_3DPIT_FORMATION_LIGHTS =231, // WD 07-2013 Formatino lights


	//ATARIBABY 12032008 separate eyebrow OXY LOW light
	COMP_3DPIT_EYEBROW_OXY_LOW = 215, //RIGHT EYEBROW caution light OXY LOW

	//ATARIBABY 23032008 
	COMP_3DPIT_CAUTION_EQUIP_HOT=216, //Caution panel EQUIP_HOT light
	
	//ATARIBABY 21042008 
	COMP_3DPIT_FLCS_PWR_TEST=228, //FLCS PWR TEST light

	//ATARIBABY 21042008 
	COMP_3DPIT_FLT_CONTROL_RUN_FAIL=229, //FLT CONTROL RUN/FAIL lights

	COMP_3DPIT_EYEBROW_DBUON = 235, //RIGHT EYEBROW caution light DBU ON

	COMP_3DPIT_BUP_RADIO_DIGIT_DISPLAY = 236,  // MD -- 20091120: for UHF control head preset display
	
	COMP_3DPIT_CAUTION_ATF_NOT_ENGAGED = 237, //ATARIBABY Caution panel ATF NOT ENGAGED light

	COMP_3DPIT_TOGGLE_LEGS = 238, //JP for LEGS and ARMS

	SIMP_AB				= 0,
	SIMP_TANKERLIGHTS	= 1,
	SIMP_GEAR			= 2,
	SIMP_WING_VAPOR		= 3,
	SIMP_CANOPY			= 5,
	SIMP_DRAGCHUTE		= 6,
	SIMP_HOOK		= 7,
	SIMP_MAX_SWITCH		= 8,

	HELI_ROTORS		= 0,
	HELI_MAX_SWITCH		 = 2,

	MISS_DEPLOYED_WINGS = 0,
	MISS_BOOSTER		= 1,
	MISS_TAIL_FINS		= 2,
	

	// BMS - Biker - 2016/06/24 - We no can define the switches in the *.VEH files
	AIRDEF_MAX_SWITCH	= 255,
};

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// BMS - Biker - 2015/01/17 - Just for documentation, these DOFs are used by scripts, so we should have an open eye
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// DOF #0	-> Beacon
// DOF #2	-> AH64, C130, E3, UH1, LongBow, Hokum, OneProp, TU95
// DOF #3	-> AH64, C130, UH1, LongBow, Hokum, TU95
// DOF #4	-> AH64, C130, LongBow, Hokum, TU95
// DOF #5	-> C130, LongBow, TU95
// DOF #6	-> TU95
// DOF #7	-> TU95
// DOF #8	-> TU95
// DOF #9	-> TU95
// DOF #14	-> ComplexE3
// DOF #31	-> ComplexProp
// DOF #32	-> ComplexProp
// DOF #33	-> ComplexProp
// DOF #34	-> ComplexProp
// DOF #35	-> ComplexProp
// DOF #36	-> ComplexProp
// DOF #37	-> ComplexProp
// DOF #38	-> ComplexProp -> "maxd = min(maxd, 38); for (int i = 31; i < maxd; i++)" isn't this a bug? Shouldn't it be "<=", shouldn't we have 8 props?


enum DOFS{
	COMP_LT_STAB		= 0,
	COMP_RT_STAB		= 1,
	COMP_LT_FLAP		= 2, // Flapperons or ailerons
	COMP_RT_FLAP		= 3,
	COMP_RUDDER			= 4,
	COMP_NOS_GEAR_ROT	= 5,

	/* MLR 2/22/2004 - Do not use these ID's in the code anymore, use the arrays at the bottom of this file 
	COMP_NOS_GEAR_COMP	= 6,
	COMP_LT_GEAR_COMP	= 7,
	COMP_RT_GEAR_COMP	= 8,
	*/

//	COMP_FREE1	= 6,
	COMP_WING_FOLD = 6,
	COMP_REVERSE_THRUST = 7,
//	COMP_FREE2	= 7,
	COMP_FREE3	= 8,

	COMP_LT_LEF			= 9,
	COMP_RT_LEF			= 10,
	COMP_BROKEN_NOS_GEAR= 11,
	COMP_BROKEN_LT_GEAR = 12,
	COMP_BROKEN_RT_GEAR = 13,
	COMP_NOTUSED_14		= 14,//available - not so fast as it seems 14 is used for AWACS radome!
	COMP_LT_AIR_BRAKE_TOP = 15,
	COMP_LT_AIR_BRAKE_BOT = 16,
	COMP_RT_AIR_BRAKE_TOP = 17,
	COMP_RT_AIR_BRAKE_BOT = 18,

	/* MLR 2/22/2004 - Do not use these ID's in the code anymore, use the arrays at the bottom of this file 
	COMP_NOS_GEAR		= 19,
	COMP_LT_GEAR		= 20,
	COMP_RT_GEAR		= 21,
	COMP_NOS_GEAR_DR	= 22,
	COMP_LT_GEAR_DR		= 23,
	COMP_RT_GEAR_DR		= 24, */


	/* MLR 2/22/2004 - Do not use these ID's in the code anymore, use the arrays at the bottom of this file */
	COMP_GEAR_1			= 19,
	COMP_GEAR_2			= 20,
	COMP_GEAR_3			= 21,
	COMP_GEAR_DR_1		= 22,
	COMP_GEAR_DR_2		= 23,
	COMP_GEAR_DR_3		= 24, 

	// 25-27 are used in some models (like F16) for landing gear bits
	// hence this gap
	// MLR-NOTE erm, where?

	//WingFlex
	COMP_WINGFLEX_L = 25,
	COMP_WINGFLEX_R = 26,
	//
	COMP_CANARDS = 27, //JP 090218

	COMP_LT_TEF		= 28, // JPO
	COMP_RT_TEF		= 29,
	COMP_CANOPY_DOF		= 30, // opening canopy
	// 31-37 earmarked for prop animation DOFs, so next named one should be 37 please.

  COMP_TAILHOOK =   37,
  COMP_ABDOF =      38, // afterburner DOF, for scaling.
  COMP_EXH_NOZ =    39, // exhuast nozzle

  COMP_PROPELLOR  = 40,
  COMP_REFUEL     = 41, // refuel probe
  COMP_LT_SPOILER1  = 42,
  COMP_RT_SPOILER1  = 43,
  COMP_LT_SPOILER2  = 44,
  COMP_RT_SPOILER2  = 45,

  COMP_SWING_WING = 46,
  COMP_THROTTLE   = 47,
  COMP_RPM        = 48,

  COMP_TOE_IN	  = 49,

  COMP_WHEEL_1   =   50, // MLR 2003-10-04 // 2003-10-14 renamed
  COMP_WHEEL_2   =   51,
  COMP_WHEEL_3   =   52,
  COMP_WHEEL_4   =   53,
  COMP_WHEEL_5   =   54,
  COMP_WHEEL_6   =   55,
  COMP_WHEEL_7   =   56,
  COMP_WHEEL_8   =   57,
  COMP_GEAREXTENSION_1   =   58, // MLR 2003-10-04
  COMP_GEAREXTENSION_2   =   59,
  COMP_GEAREXTENSION_3   =   60,
  COMP_GEAREXTENSION_4   =   61,
  COMP_GEAREXTENSION_5   =   62,
  COMP_GEAREXTENSION_6   =   63,
  COMP_GEAREXTENSION_7   =   64, // hmm >64 dofs?
  COMP_GEAREXTENSION_8   =   65,
  COMP_ABDOF2			 =   66, // afterburner DOF, for scaling.
  COMP_EXH_NOZ2          =   67, // exhuast nozzle

	/* Do not use these ID's in the code anymore, use the arrays at the bottom of this file */
  	COMP_GEAR_4			= 68,
  	COMP_GEAR_5			= 69,
  	COMP_GEAR_6			= 70,
  	COMP_GEAR_7			= 71,
  	COMP_GEAR_8			= 72,

	/* Do not use these ID's in the code anymore, use the arrays at the bottom of this file */
	COMP_GEAR_DR_4		= 73,
	COMP_GEAR_DR_5		= 74,
	COMP_GEAR_DR_6		= 75,
	COMP_GEAR_DR_7		= 76,
	COMP_GEAR_DR_8		= 77,

	COMP_WEAPON_BAY_0  = 78,
	COMP_WEAPON_BAY_1  = 79,
	COMP_WEAPON_BAY_2  = 80,
	COMP_WEAPON_BAY_3  = 81,
	COMP_WEAPON_BAY_4  = 82,

	COMP_INTAKE_1_RAMP_1 = 83,
	COMP_INTAKE_1_RAMP_2 = 84,
	COMP_INTAKE_1_RAMP_3 = 85,

	COMP_INTAKE_2_RAMP_1 = 86,
	COMP_INTAKE_2_RAMP_2 = 87,
	COMP_INTAKE_2_RAMP_3 = 88,
	
	// Retro / Ataribaby Pilot head
	COMP_PILOT1_HEAD_TILT = 89,
	COMP_PILOT1_HEAD_PAN = 90,
	COMP_PILOT2_HEAD_TILT = 91,
	COMP_PILOT2_HEAD_PAN = 92,
	// Retro / Ataribaby Pilot head end

	COMP_TGP_HEAD_ROLL = 93,
	COMP_TGP_HEAD_ELEVATION = 94,

	//JP VTOL Exhaust DOFS (can be improved with differential DOfs)
	COMP_VTOL = 95,
	COMP_FLUTTER_1 = 96,
	COMP_FLUTTER_2 = 97,
	
	//Wing flex
	//COMP_WINGFLEX = 98, no more used here , see 25 & 26

	COM_LAUNCH_BAR = 98,
	COMP_HELMET_VISOR = 99, //Pilot Visor
	COMP_MAX_DOF = 100, // Make sure this is up to date!

  //ATARIBABY start new 3d cokpit dofs, i made enought hole i hope
  COMP_3DPIT_ADI_ROLL   = 100,  //main adi ball roll
  COMP_3DPIT_ADI_PITCH  = 101, //main adi ball pitch
  COMP_3DPIT_ASI_NEEDLE  = 102, //asi instrument needle
  COMP_3DPIT_BACKUP_ADI_ROLL   = 103, //backup adi ball roll
  COMP_3DPIT_BACKUP_ADI_PITCH  = 104, //backup adi ball pitch
  COMP_3DPIT_ALT_NEEDLE  = 105, //alt instrument needle
  COMP_3DPIT_ILSV_NEEDLE  = 106, //ILS vertical needle
  COMP_3DPIT_ILSH_NEEDLE  = 107, //ILS horizontal needle
  COMP_3DPIT_MAG_COMPASS  = 108, //backup magnetic compass
  COMP_3DPIT_ASIMACH_DIGIT1  = 109, //ASI mach digital readout left digit
  COMP_3DPIT_ASIMACH_DIGIT2  = 110, //ASI mach digital readout right digit
  COMP_3DPIT_ALT_DIGIT1  = 111, //ALT digital readout digit 1
  COMP_3DPIT_ALT_DIGIT2  = 112, //ALT digital readout digit 2
  COMP_3DPIT_ALT_DIGIT3  = 113, //ALT digital readout digit 3
  COMP_3DPIT_HSI_HDG  = 114, //HSI current heading
  COMP_3DPIT_HSI_CRS  = 115, //HSI desired course
  COMP_3DPIT_HSI_DHDG  = 116, //HSI desired heading
  COMP_3DPIT_HSI_BCN  = 117, //HSI beacon course
  COMP_3DPIT_HSI_CRSDEV  = 118, //HSI course deviation
  COMP_3DPIT_HSI_DIST_DIGIT1  = 119, //HSI distance to beacon digit 1
  COMP_3DPIT_HSI_DIST_DIGIT2  = 120, //HSI distance to beacon digit 2
  COMP_3DPIT_HSI_DIST_DIGIT3  = 121, //HSI distance to beacon digit 3
  COMP_3DPIT_HSI_CRS_DIGIT1  = 122, //HSI course beacon digit 1
  COMP_3DPIT_HSI_CRS_DIGIT2  = 123, //HSI course to beacon digit 2
  COMP_3DPIT_HSI_CRS_DIGIT3  = 124, //HSI course digit 3
  COMP_3DPIT_FUELFLOW_DIGIT1  = 125, //FUEL FLOW digit 1
  COMP_3DPIT_FUELFLOW_DIGIT2  = 126, //FUEL FLOW digit 2
  COMP_3DPIT_FUELFLOW_DIGIT3  = 127, //FUEL FLOW digit 3
  COMP_3DPIT_OIL_NEEDLE  = 128, //OIL needle
  COMP_3DPIT_NOZ_NEEDLE  = 129, //NOZ needle
  COMP_3DPIT_RPM_NEEDLE  = 130, //RPM needle
  COMP_3DPIT_FTIT_NEEDLE  = 131, //FTIT needle
  COMP_3DPIT_AOA  = 132, //AOA tape
  COMP_3DPIT_VVI  = 133, //VVI tape
  COMP_3DPIT_HYDA_NEEDLE  = 134, //HYD A PRESS needle
  COMP_3DPIT_HYDB_NEEDLE  = 135, //HYD B PRESS needle
  COMP_3DPIT_EPU_NEEDLE  = 136, //EPU needle
  COMP_3DPIT_FUEL_DIGIT1  = 137, //FUEL digit 1
  COMP_3DPIT_FUEL_DIGIT2  = 138, //FUEL digit 2
  COMP_3DPIT_FUEL_DIGIT3  = 139, //FUEL digit 3
  COMP_3DPIT_FUEL_DIGIT4  = 140, //FUEL digit 4
  COMP_3DPIT_FUEL_DIGIT5  = 141, //FUEL digit 5
  COMP_3DPIT_FUELAFT_NEEDLE  = 142, //FUEL AFT
  COMP_3DPIT_FUELFWD_NEEDLE  = 143, //FUEL FWD
  COMP_3DPIT_G_NEEDLE  = 144, //G-meter needle
  COMP_3DPIT_GEAR_HANDLE  = 145, //Gear handle
  COMP_3DPIT_SEAT_ARM  = 146, //Ejection seat arm handle
  COMP_3DPIT_STICK_ROLL  = 147, //Flight stick roll
  COMP_3DPIT_STICK_PITCH  = 148, //Flight stick pitch
  //Reminder for me (i am dumb after a while, because nurses nurses everywhere):
  //***** Throttle is DOF 47. Fueled in surface.cpp by Mike *****
  COMP_3DPIT_RUDDER  = 149, //Rudder
  COMP_3DPIT_SYM_WHEEL  = 150, //HUD SYM wheel
  COMP_3DPIT_DEPR_WHEEL  = 151, //HUD DEPR wheel
  COMP_3DPIT_ASIMACH  = 152, //ASI mach rotating dial
  COMP_3DPIT_AIRBRAKE  = 153, //Airbrakes pos indicator
  COMP_3DPIT_TACAN_MODE=154, //TACAN mode Y/X
  COMP_3DPIT_TACAN_DIGIT1=155, //TACAN digit 1
  COMP_3DPIT_TACAN_DIGIT2=156, //TACAN digit 2
  COMP_3DPIT_TACAN_DIGIT3=157, //TACAN digit 3
  COMP_3DPIT_TRIM_PITCH=158, //Pitch trim needle
  COMP_3DPIT_TRIM_ROLL=159, //Roll trim needle
  COMP_3DPIT_TRIM_YAW=160, //Yaw trim knob
  COMP_3DPIT_CABIN_PRESS=161, //Cabin press needle
  COMP_3DPIT_CLOCK_HOUR=162, //Clock hour needle
  COMP_3DPIT_CLOCK_MINUTE=163, //CLock minute needle
  COMP_3DPIT_CLOCK_SECOND=164, //Clock second needle
  COMP_3DPIT_CHAN_DIGIT1=165, //Backup UHF channel digit 1
  COMP_3DPIT_CHAN_DIGIT2=166, //Backup UHF channel digit 2
  COMP_3DPIT_THROTTLE  = 167, //Throttle
  COMP_3DPIT_THROTTLE2  = 168, //Throttle
  
  
  //ATARIBABY end

  //JP 290909
  COMP_3DPIT_ALTCALFIRSDIGIT = 169,
  COMP_3DPIT_ALCALTSECODIGIT = 170,
  COMP_3DPIT_ALCALTTHIRDIGIT = 171,
  COMP_3DPIT_ALCALTFOURDIGIT = 172,
  COMP_3DPIT_RADAR_ALT = 173,
  COMP_3DPIT_WING_FOLD_HANDLE = 174,

  COMP_3DPIT_RPM_NEEDLE2 = 175,
  COMP_3DPIT_NOZ_NEEDLE2  = 176,
  COMP_3DPIT_FTIT_NEEDLE2  = 177, //FTIT needle

  COMP_3DPIT_FUELFLOW2_DIGIT1  = 178, //FUEL FLOW digit 1
  COMP_3DPIT_FUELFLOW2_DIGIT2  = 179, //FUEL FLOW digit 2
  COMP_3DPIT_FUELFLOW2_DIGIT3  = 180, //FUEL FLOW digit 3

  COMP_3DPIT_BRT_WHEEL = 181, //HUD BRT wheel

  COMP_3DPIT_OIL_NEEDLE2  = 182, //OIL needle
 
	SIMP_LT_STAB		= 0,
	SIMP_RT_STAB		= 1,
	// this gap used by animations (including 6 & 7 actually) JPO
	SIMP_LT_AILERON		= 6,
	SIMP_RT_AILERON		= 7,
	SIMP_RUDDER_1		= 8,
	SIMP_RUDDER_2		= 9,
	SIMP_AIR_BRAKE		= 10,
	SIMP_SWING_WING_1	= 11,
	SIMP_SWING_WING_2	= 12,
	SIMP_SWING_WING_3	= 13,
	SIMP_SWING_WING_4	= 14,
	SIMP_SWING_WING_5	= 15,
	SIMP_SWING_WING_6	= 16,
	SIMP_SWING_WING_7	= 17,
	SIMP_SWING_WING_8	= 18,
	SIMP_RT_TEF		= 19, // JPO - new stuff
	SIMP_LT_TEF		= 20,
	SIMP_RT_LEF		= 21,
	SIMP_LT_LEF		= 22,
	SIMP_CANOPY_DOF		= 23, // opening canopy

  SIMP_PROPELLOR  = 40,
  SIMP_REFUEL     = 41, // refuel probe


  SIMP_LT_SPOILER1  = 42,
  SIMP_RT_SPOILER1  = 43,
  SIMP_LT_SPOILER2  = 44,
  SIMP_RT_SPOILER2  = 45,

  SIMP_THROTTLE   = 47,
  SIMP_RPM        = 48,

	SIMP_MAX_DOF		= 49, // MAKE SURE THIS IS UP TO DATE


	HELI_MAIN_ROTOR		= 2,
	HELI_TAIL_ROTOR		= 4,
	HELI_MAX_DOF		= 255,

	AIRDEF_AZIMUTH		= 0,
	AIRDEF_ELEV		= 1,
	AIRDEF_ELEV2		= 2,
	AIRDEF_JBD_FRONT_LEFT		=3,
	AIRDEF_JBD_FRONT_RIGHT	=4,
	AIRDEF_JBD_BACK_LEFT = 5,
	AIRDEF_JBD_BACK_RIGHT = 6,
	AIRDEF_CHOCKS_FRONT_LEFT = 7,
	AIRDEF_CHOCKS_FRONT_RIGHT = 8,
	AIRDEF_CHOCKS_BACK_LEFT = 9,

	// BMS - Biker - 2016/06/24 - We no can define the DOFs in the *.VEH files
	AIRDEF_MAX_DOF		= 255,

	MISS_BODY_ROLL		= 0,
	MISS_FLAME_ROLL		 = 1,
	MISS_MAX_DOF		= 2,

	FEAT_WINDMILL_AZIMUTH	= 15,
	FEAT_WINDMILL_ROTATION	= 16,
	FEAT_WINDSOCK_AZIMUTH = 15,
	FEAT_WINDSOCK_EXTENSION = 16,
};
// MLR 2/22/2004 -  these arrays will store the actual DOF/SWITCH ids, 
//                  seeing as they are not sequential after gear 3.
extern int ComplexGearDOF[];			// landing gear retraction/extension angle
extern int ComplexGearDoorDOF[];		// door angle
extern int ComplexGearSwitch[];			// gear visible switch
extern int ComplexGearDoorSwitch[];		// door visible switch
extern int ComplexGearHoleSwitch[];		// gear bay switch 
extern int ComplexGearBrokenSwitch[];



enum Vertices {
    AIRCRAFT_MAX_DVERTEX = 6,
	HELI_MAX_DVERTEX = 0,
	VECH_MAX_DVERTEX = 0,

};


//Dunc 20140920: switches to be transferred in MP for human controlled A/C
#define NUM_REMOTE_SWITCHES 4
static const int MPRemoteSwitches[] = {
	COMP_WING_VAPOR,
	COMP_HOOK,
	COMP_DRAGCHUTE,
	COMP_FORMATION_LIGHTS
};

//Dunc 20140920: DOFs to be transferred in MP for human controlled A/C
#define NUM_REMOTE_DOFS 19
static const int MPRemoteDOFs[] = {
	COMP_LT_STAB,
	COMP_RT_STAB,
	COMP_LT_FLAP,
	COMP_RT_FLAP,
	COMP_RUDDER,
	COMP_NOS_GEAR_ROT,
	COMP_LT_LEF,
	COMP_RT_LEF,
	COMP_LT_TEF,
	COMP_RT_TEF,
	COMP_ABDOF,
	COMP_EXH_NOZ,
	COMP_REFUEL,
	//COMP_GEAREXTENSION_1,
	//COMP_GEAREXTENSION_2,
	//COMP_GEAREXTENSION_3,
	//COMP_GEAREXTENSION_4,
	COMP_ABDOF2,
	COMP_EXH_NOZ2,
	COMP_PILOT1_HEAD_TILT,
	COMP_PILOT1_HEAD_PAN,
	COMP_VTOL,
	COMP_HELMET_VISOR,
};

// Allow local dof computed changes for remote aircraft entities (on client, usualy computed in AircraftClass::MoveSurfaces) 
#define NUM_REMOTE_EXCLUDED_DOFS 9
static const int MPRemoteExcludedDOFs[] = {
	COMP_LT_STAB,
	COMP_RT_STAB,
	COMP_PILOT1_HEAD_TILT,
	COMP_PILOT1_HEAD_PAN,
	COMP_HELMET_VISOR,
	COMP_ABDOF,
	COMP_EXH_NOZ,
	COMP_ABDOF2,
	COMP_EXH_NOZ2,
};

#endif

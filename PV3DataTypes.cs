using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV3TestUtility3
{
    class PV3DataTypes
    {
        public enum PV3CommandType
        {
            READ_VERSION = 0x00,
            BOOTLOAD = 0x10, //Enter bootloader mode

            ID_BOARD = 0x31,
            UPDATE_LED = 0x32,
            SET_TEMP_REAL = 0x33,
            RD_TEMP = 0x34,
            SET_TEMP_LOGGING = 0x35,
            RD_TEMP_LOGGING = 0x36,
            RD_POT = 0x37,

            TOGGLE_LEDS = 0x80,
            RD_SW2 = 0x81,

            START_DATA_ACQ = 0xA0, //Start acquisition of data
            STOP_DATA_ACQ = 0xA1, //Stop acquisition of data

            RD_DATA_EEPROM_CHECKSUM = 0xA2, //Return sum of DATA EEPROM contents

            RD_LSSDP = 0xEB, //Read low speed sensor data packet
            SET_LUNG_SN = 0xEC, //Write SNPkt to TTL (PC to TTL)
            RD_LUNG_SN = 0xED, //Read SNPkt from TTL (TTL to PC)
            SET_LUNG_MODEL = 0xEE, //Write LungModel to TTL (PC to TTL)
            RD_LUNG_MODEL = 0xEF, //Read LungModel from TTL (TTL to PC)

            SET_CH0_GAIN = 0xF0, //Set CH0 gain
            SET_CH1_GAIN = 0xF1, //Set CH1 gain
            SET_CH2_GAIN = 0xF2, //Set CH2 gain
            SET_CH3_GAIN = 0xF3, //Set CH3 gain
            SET_CH4_GAIN = 0xF4, //Set CH4 gain
            SET_ZEROS = 0xF5, //Set zero offset values for high speed sensor channels
            RD_HSSCD = 0xF6, //Read high speed sensor calibration data
            SET_RLTO = 0xF7, //Set right lung temperature sensor offset
            SET_RLTG = 0xF8, //Set right lung temperature sensor gain
            SET_LLTO = 0xF9, //Set left lung emperature sensor offset
            SET_LLTG = 0xFA, //Set left lung temperature sensor gain
            SET_O2O = 0xFB, //Set O2 sensor offset
            SET_O2G = 0xFC, //Set O2 sensor gain
            RD_LSSCD = 0xFD, //Read low speed sensor calibration data
            RD_HSSDP = 0xFE, //Read High speed sensor data packet
            RESET = 0xFF,

            RESET_FROM_BOOTLOADER = 0x08 //Reset MCU from the Microchip HID Bootloader firmware
        }

        public byte ttlModel = 0;                              //Flag indicating the TTL model attached
        public byte[] ttlSN = new byte[2];                     //Byte array for the serial number of the TTL attached
        
        public ushort PPROXZero = 939;
        public ushort PLEFTZero = 915;
        public ushort PRGHTZero = 919;
        public ushort PHIGHZero = 150;
        public ushort AUXINZero = 815;

        public ushort PPROXGain = 44944;
        public ushort PLEFTGain = 44944;
        public ushort PRGHTGain = 44944;
        public ushort PHIGHGain = 1;
        public ushort AUXINGain = 1;
        
        public ushort PPROXRaw;
        public ushort PLEFTRaw;
        public ushort PRGHTRaw;
        public ushort PHIGHRaw;
        public ushort AUXINRaw;

        private double pprox;

        public double PPROX
        {
            get {
                pprox = (PPROXRaw - PPROXZero) * PPROXGain / 1000000.0;
                return pprox; 
            }
            set { pprox = value; }
        }

        private double pleft;

        public double PLEFT
        {
            get {
                pleft = (PLEFTRaw - PLEFTZero) * PLEFTGain / 1000000.0;
                return pleft; 
            }
            set { pleft = value; }
        }

        private double prght;

        public double PRGHT
        {
            get {
                prght = (PRGHTRaw - PRGHTZero) * PRGHTGain / 1000000.0;
                return prght; 
            }
            set { prght = value; }
        }

        private double phigh;

        public double PHIGH
        {
            get {
                phigh = (PHIGHRaw - PHIGHZero) * PHIGHGain;
                return phigh; 
            }
            set { phigh = value; }
        }

        private double auxin;

        public double AUXIN
        {
            get {
                auxin = (AUXINRaw - AUXINZero) * AUXINGain;
                return auxin; 
            }
            set { auxin = value; }
        }

        public ushort FiO2Zero;
        public ushort TLEFTZero;
        public ushort TRGHTZero;

        public ushort FiO2Gain;
        public ushort TLEFTGain;
        public ushort TRGHTGain;
        
        public ushort FiO2Raw;
        public ushort TLEFTRaw;
        public ushort TRGHTRaw;
        
        private double fio2;

        public double FiO2
        {
            get { return fio2; }
            set { fio2 = value; }
        }

        private double tleft;

        public double TLEFT
        {
            get
            {
                tleft = (TLEFTRaw >> 3) + (TLEFTRaw & 0x07)*0.125;
                return tleft;
            }
            set { tleft = value; }
        }

        private double trght;

        public double TRGHT
        {
            get { return trght; }
            set { trght = value; }
        }

    }
}

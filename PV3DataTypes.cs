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
    }
}

﻿namespace PcapNgNet;

public enum LinkType : ushort
{
    None = 0,
    Ethernet = 1,
    ExperimentalEthernet = 2,
    Ax25 = 3,
    Pronet = 4,
    Chaos = 5,
    TokenRing = 6,
    Arcnet = 7,
    Slip = 8,
    Ppp = 9,
    Fddi = 10,
    PppHdlc = 50,
    PppEther = 51,
    SymantecFirewall = 99,
    Atm = 100,
    Raw = 101,
    SlipBsd = 102,
    PppBsd = 103,
    CicsoHdlc = 104,
    Wifi = 105,
    AtmClip = 106,
    FrameRelay = 107,
    Loop = 108,
    IpSec = 109,
    Lane8023 = 110,
    Hippi = 111,
    Hdlc = 112,
    LinuxSll = 113,
    LocalTalk = 114,
    Econet = 115,
    IpFilter = 116,
    PfLog = 117,
    CiscoIos = 118,
    Prism = 119,
    Aironet = 120,
    Hhdlc = 121,
    IpOverFiber = 122,
    SunAtm = 123,
    RapidIo = 124,
    PciExpress = 125,
    Aurora = 126,
    WifiRadio = 127,
    Tzsp = 128,
    ArcnetLinux = 129,
    JuniperMlppp = 130,
    JuniperMlfr = 131,
    JuniperEs = 132,
    JuniperGgsn = 133,
    JuniperMfr = 134,
    JuniperAtm2 = 135,
    JuniperServices = 136,
    JuniperAtm1 = 137,
    AppleIpOverFirewire = 138,
    LinuxIrda = 144
}

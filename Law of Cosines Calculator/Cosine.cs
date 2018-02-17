using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Cosine
    {
    private double _knownSide1; // instance variable

    // The first known side the user will enter 
    public double KnownSide1
    {
        get
        {
            return _knownSide1;
        }
        set
        {
            _knownSide1 = value;
        }
    }

    private double _knownSide2; // instance variable

    // The second known side the user will enter 
    public double KnownSide2
    {
        get
        {
            return _knownSide2;
        }
        set
        {
            _knownSide2 = value;
        }
    }

    private double _knownAngle; // instance variable

    // The known angle the user will enter 
    public double KnownAngle
    {
        get
        {
            return _knownAngle;
        }
        set
        {
            _knownAngle = value;
        }
    }

    private double _knownAngleRadians; // instance variable

    // The known angle converted into radians 
    public double KnownAngleRadians
    {
        get
        {
            return _knownAngleRadians;
        }
        set
        {
            _knownAngleRadians = value;
        }
    }

    private double _knownAngleCos; // instance variable

    // The radians of the known angle converted into the Cosine of that angle 
    public double KnownAngleCos
    {
        get
        {
            return _knownAngleCos;
        }
        set
        {
            _knownAngleCos = value;
        }
    }


    private double _missingSide; // instance variable

    // The missing side we are trying to find
    public double MissingSide
    {
        get
        {
            return _missingSide;
        }
        set
        {
            _missingSide = value;
        }
    }


    // Calculate the missing side using the law of cosines
    // C = sqrt(a^2 + b^2 - 2ab cosy)

    private double _aPow2; // instance variable

    // The first known side to the second power
    public double APow2
    {
        get
        {
            return _aPow2;
        }
        set
        {
            _aPow2 = value;
        }
    }

    private double _bPow2; // instance variable

    // The first known side to the second power
    public double BPow2
    {
        get
        {
            return _bPow2;
        }
        set
        {
            _bPow2 = value;
        }
    }

    private string _initiate; // instance variable

    // The first known side to the second power
    public string Initiate
    {
        get
        {
            return _initiate;
        }
        set
        {
            _initiate = value;
        }
    }


}


﻿namespace Unosquare.PiGpio.NativeTypes
{
    using NativeEnums;
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Defines a signature for a pthread worker.
    /// Use built-in CLR <see cref="System.Threading.Thread"/> instead.
    /// </summary>
    /// <param name="userData">The user data.</param>
    public delegate void PiGpioThreadDelegate(UIntPtr userData);

    /// <summary>
    /// Defines a signature for alert callbacks. Conatins the pin number, a level change and a microseconds
    /// timestamp. The timestamp wraps around every ~72 minutes.
    /// Unlike Interrupts, alerts are generated by continuously sampling the value of the pin.
    /// </summary>
    /// <param name="userGpio">The user gpio.</param>
    /// <param name="levelChange">The level change.</param>
    /// <param name="timeMicrosecs">The microseconds timestamp.</param>
    public delegate void PiGpioAlertDelegate(UserGpio userGpio, LevelChange levelChange, uint timeMicrosecs);

    /// <summary>
    /// Defines a signature for alert callbacks. Conatins the pin number, a level change and a microseconds
    /// timestamp. The timestamp wraps around every ~72 minutes.
    /// Unlike Interrupts, alerts are generated by continuously sampling the value of the pin.
    /// </summary>
    /// <param name="userGpio">The user gpio.</param>
    /// <param name="levelChange">The level change.</param>
    /// <param name="timeMicrosecs">The time microsecs.</param>
    /// <param name="userData">The user data.</param>
    public delegate void PiGpioAlertExDelegate(UserGpio userGpio, LevelChange levelChange, uint timeMicrosecs, UIntPtr userData);

    /// <summary>
    /// Defines a signature for ISR callbacks. Conatins the pin number, a level change and a microseconds
    /// timestamp. The timestamp wraps around every ~72 minutes.
    /// Unlike alerts, interrupts are generated with level changes. Make sure you hookup pull-down/pull-up resitors
    /// for interrupts to work as they depend on current flowing through the pin in order to fire consistently.
    /// </summary>
    /// <param name="gpio">The gpio.</param>
    /// <param name="level">The level.</param>
    /// <param name="timeMicrosecs">The time microsecs.</param>
    public delegate void PiGpioIsrDelegate(SystemGpio gpio, LevelChange level, uint timeMicrosecs);

    /// <summary>
    /// Defines a signature for ISR callbacks. Conatins the pin number, a level change and a microseconds
    /// timestamp. The timestamp wraps around every ~72 minutes.
    /// Unlike alerts, interrupts are generated with level changes. Make sure you hookup pull-down/pull-up resitors
    /// for interrupts to work as they depend on current flowing through the pin in order to fire consistently.
    /// </summary>
    /// <param name="gpio">The gpio.</param>
    /// <param name="level">The level.</param>
    /// <param name="timeMicrosecs">The time microsecs.</param>
    /// <param name="userData">The user data.</param>
    public delegate void PiGpioIsrExDelegate(SystemGpio gpio, LevelChange level, uint timeMicrosecs, UIntPtr userData);

    /// <summary>
    /// Defines a callback for a pigpio library timer
    /// Use built-in CLR <see cref="System.Threading.Timer"/> instead.
    /// </summary>
    public delegate void PiGpioTimerDelegate();

    /// <summary>
    /// Defines a callback for a pigpio library timer
    /// Use built-in CLR <see cref="System.Threading.Timer"/> instead.
    /// </summary>
    /// <param name="userData">The user data.</param>
    public delegate void PiGpioTimerExDelegate(UIntPtr userData);

    /// <summary>
    /// Callback for when an pigpio library event firing. This represents an event model internal
    /// to the pigpio library. Use the buil-in <see cref="EventHandler"/> CLR constructs instead.
    /// </summary>
    /// <param name="eventId">The event identifier.</param>
    /// <param name="timeMicrosecs">The time microsecs.</param>
    public delegate void PiGpioEventDelegate(int eventId, uint timeMicrosecs);

    /// <summary>
    /// Callback for when an pigpio library event firing. This represents an event model internal
    /// to the pigpio library. Use the buil-in <see cref="EventHandler"/> CLR constructs instead.
    /// </summary>
    /// <param name="eventId">The event identifier.</param>
    /// <param name="tick">The tick.</param>
    /// <param name="userData">The user data.</param>
    public delegate void PiGpioEventExDelegate(int eventId, uint tick, UIntPtr userData);

    /// <summary>
    /// Defines a callback to be executed when the OS sends a signal.
    /// </summary>
    /// <param name="signalNumber">The OS signal number.</param>
    public delegate void PiGpioSignalDelegate(int signalNumber);

    /// <summary>
    /// Defines a callback to be executed when the OS sends a signal.
    /// </summary>
    /// <param name="signalNumber">The OS signal number.</param>
    /// <param name="userData">The user data.</param>
    public delegate void PiGpioSignalExDelegate(int signalNumber, UIntPtr userData);

    /// <summary>
    /// Bulk pin sampling delegate. Not used in the managed model of this library.
    /// </summary>
    /// <param name="samples">The samples.</param>
    /// <param name="numSamples">The number samples.</param>
    public delegate void PiGpioGetSamplesDelegate([Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] GpioSample[] samples, int numSamples);

    /// <summary>
    /// Bulk pin sampling delegate. Not used in the managed model of this library.
    /// </summary>
    /// <param name="samples">The samples.</param>
    /// <param name="numSamples">The number samples.</param>
    /// <param name="userData">The user data.</param>
    public delegate void PiGpioGetSamplesExDelegate([Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] GpioSample[] samples, int numSamples, UIntPtr userData);
}

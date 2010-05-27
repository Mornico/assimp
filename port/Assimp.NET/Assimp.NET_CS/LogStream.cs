/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class LogStream : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal LogStream(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(LogStream obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~LogStream() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Assimp_NETPINVOKE.delete_LogStream(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void write(string message) {
    Assimp_NETPINVOKE.LogStream_write(swigCPtr, message);
  }

  public static LogStream createDefaultStream(aiDefaultLogStream stream, string name, IOSystem io) {
    IntPtr cPtr = Assimp_NETPINVOKE.LogStream_createDefaultStream__SWIG_0((int)stream, name, IOSystem.getCPtr(io));
    LogStream ret = (cPtr == IntPtr.Zero) ? null : new LogStream(cPtr, false);
    return ret;
  }

  public static LogStream createDefaultStream(aiDefaultLogStream stream, string name) {
    IntPtr cPtr = Assimp_NETPINVOKE.LogStream_createDefaultStream__SWIG_1((int)stream, name);
    LogStream ret = (cPtr == IntPtr.Zero) ? null : new LogStream(cPtr, false);
    return ret;
  }

  public static LogStream createDefaultStream(aiDefaultLogStream stream) {
    IntPtr cPtr = Assimp_NETPINVOKE.LogStream_createDefaultStream__SWIG_2((int)stream);
    LogStream ret = (cPtr == IntPtr.Zero) ? null : new LogStream(cPtr, false);
    return ret;
  }

}

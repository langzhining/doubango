/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class ProxyAudioConsumer : ProxyPlugin {
  private HandleRef swigCPtr;

  internal ProxyAudioConsumer(IntPtr cPtr, bool cMemoryOwn) : base(tinyWRAPPINVOKE.ProxyAudioConsumer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ProxyAudioConsumer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ProxyAudioConsumer() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_ProxyAudioConsumer(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public bool setActualSndCardPlaybackParams(int nPtime, int nRate, int nChannels) {
    bool ret = tinyWRAPPINVOKE.ProxyAudioConsumer_setActualSndCardPlaybackParams(swigCPtr, nPtime, nRate, nChannels);
    return ret;
  }

  public bool queryForResampler(ushort nInFreq, ushort nOutFreq, ushort nFrameDuration, ushort nChannels, ushort nResamplerQuality) {
    bool ret = tinyWRAPPINVOKE.ProxyAudioConsumer_queryForResampler(swigCPtr, nInFreq, nOutFreq, nFrameDuration, nChannels, nResamplerQuality);
    return ret;
  }

  public bool setPullBuffer(IntPtr pPullBufferPtr, uint nPullBufferSize) {
    bool ret = tinyWRAPPINVOKE.ProxyAudioConsumer_setPullBuffer(swigCPtr, pPullBufferPtr, nPullBufferSize);
    return ret;
  }

  public uint pull(IntPtr pOutput, uint nSize) {
    uint ret = tinyWRAPPINVOKE.ProxyAudioConsumer_pull__SWIG_0(swigCPtr, pOutput, nSize);
    return ret;
  }

  public uint pull(IntPtr pOutput) {
    uint ret = tinyWRAPPINVOKE.ProxyAudioConsumer_pull__SWIG_1(swigCPtr, pOutput);
    return ret;
  }

  public uint pull() {
    uint ret = tinyWRAPPINVOKE.ProxyAudioConsumer_pull__SWIG_2(swigCPtr);
    return ret;
  }

  public bool setGain(uint nGain) {
    bool ret = tinyWRAPPINVOKE.ProxyAudioConsumer_setGain(swigCPtr, nGain);
    return ret;
  }

  public uint getGain() {
    uint ret = tinyWRAPPINVOKE.ProxyAudioConsumer_getGain(swigCPtr);
    return ret;
  }

  public bool reset() {
    bool ret = tinyWRAPPINVOKE.ProxyAudioConsumer_reset(swigCPtr);
    return ret;
  }

  public void setCallback(ProxyAudioConsumerCallback pCallback) {
    tinyWRAPPINVOKE.ProxyAudioConsumer_setCallback(swigCPtr, ProxyAudioConsumerCallback.getCPtr(pCallback));
  }

  public virtual ulong getMediaSessionId() {
    ulong ret = tinyWRAPPINVOKE.ProxyAudioConsumer_getMediaSessionId(swigCPtr);
    return ret;
  }

  public static bool registerPlugin() {
    bool ret = tinyWRAPPINVOKE.ProxyAudioConsumer_registerPlugin();
    return ret;
  }

}

}

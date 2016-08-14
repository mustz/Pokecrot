// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/Player/DailyBonus.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Player {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Player/DailyBonus.proto</summary>
  public static partial class DailyBonusReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Player/DailyBonus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DailyBonusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQT0dPUHJvdG9zL0RhdGEvUGxheWVyL0RhaWx5Qm9udXMucHJvdG8SFlBP",
            "R09Qcm90b3MuRGF0YS5QbGF5ZXIiYwoKRGFpbHlCb251cxIjChtuZXh0X2Nv",
            "bGxlY3RlZF90aW1lc3RhbXBfbXMYASABKAMSMAoobmV4dF9kZWZlbmRlcl9i",
            "b251c19jb2xsZWN0X3RpbWVzdGFtcF9tcxgCIAEoA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Player.DailyBonus), global::POGOProtos.Data.Player.DailyBonus.Parser, new[]{ "NextCollectedTimestampMs", "NextDefenderBonusCollectTimestampMs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DailyBonus : pb::IMessage<DailyBonus> {
    private static readonly pb::MessageParser<DailyBonus> _parser = new pb::MessageParser<DailyBonus>(() => new DailyBonus());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DailyBonus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Player.DailyBonusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyBonus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyBonus(DailyBonus other) : this() {
      nextCollectedTimestampMs_ = other.nextCollectedTimestampMs_;
      nextDefenderBonusCollectTimestampMs_ = other.nextDefenderBonusCollectTimestampMs_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyBonus Clone() {
      return new DailyBonus(this);
    }

    /// <summary>Field number for the "next_collected_timestamp_ms" field.</summary>
    public const int NextCollectedTimestampMsFieldNumber = 1;
    private long nextCollectedTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NextCollectedTimestampMs {
      get { return nextCollectedTimestampMs_; }
      set {
        nextCollectedTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "next_defender_bonus_collect_timestamp_ms" field.</summary>
    public const int NextDefenderBonusCollectTimestampMsFieldNumber = 2;
    private long nextDefenderBonusCollectTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NextDefenderBonusCollectTimestampMs {
      get { return nextDefenderBonusCollectTimestampMs_; }
      set {
        nextDefenderBonusCollectTimestampMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DailyBonus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DailyBonus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NextCollectedTimestampMs != other.NextCollectedTimestampMs) return false;
      if (NextDefenderBonusCollectTimestampMs != other.NextDefenderBonusCollectTimestampMs) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NextCollectedTimestampMs != 0L) hash ^= NextCollectedTimestampMs.GetHashCode();
      if (NextDefenderBonusCollectTimestampMs != 0L) hash ^= NextDefenderBonusCollectTimestampMs.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (NextCollectedTimestampMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(NextCollectedTimestampMs);
      }
      if (NextDefenderBonusCollectTimestampMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(NextDefenderBonusCollectTimestampMs);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NextCollectedTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextCollectedTimestampMs);
      }
      if (NextDefenderBonusCollectTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextDefenderBonusCollectTimestampMs);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DailyBonus other) {
      if (other == null) {
        return;
      }
      if (other.NextCollectedTimestampMs != 0L) {
        NextCollectedTimestampMs = other.NextCollectedTimestampMs;
      }
      if (other.NextDefenderBonusCollectTimestampMs != 0L) {
        NextDefenderBonusCollectTimestampMs = other.NextDefenderBonusCollectTimestampMs;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            NextCollectedTimestampMs = input.ReadInt64();
            break;
          }
          case 16: {
            NextDefenderBonusCollectTimestampMs = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

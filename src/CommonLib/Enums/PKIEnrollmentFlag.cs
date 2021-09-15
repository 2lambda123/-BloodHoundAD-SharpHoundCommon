﻿using System;

namespace SharpHoundCommonLib.Enums
{
    // from https://docs.microsoft.com/en-us/openspecs/windows_protocols/ms-crtd/ec71fd43-61c2-407b-83c9-b52272dec8a1
    // and from certutil.exe -v -dstemplate
    [Flags]
    public enum PKIEnrollmentFlag : uint
    {
        NONE = 0x00000000,
        INCLUDE_SYMMETRIC_ALGORITHMS = 0x00000001,
        PEND_ALL_REQUESTS = 0x00000002,
        PUBLISH_TO_KRA_CONTAINER = 0x00000004,
        PUBLISH_TO_DS = 0x00000008,
        AUTO_ENROLLMENT_CHECK_USER_DS_CERTIFICATE = 0x00000010,
        AUTO_ENROLLMENT = 0x00000020,
        CT_FLAG_DOMAIN_AUTHENTICATION_NOT_REQUIRED = 0x80,
        PREVIOUS_APPROVAL_VALIDATE_REENROLLMENT = 0x00000040,
        USER_INTERACTION_REQUIRED = 0x00000100,
        ADD_TEMPLATE_NAME = 0x200,
        REMOVE_INVALID_CERTIFICATE_FROM_PERSONAL_STORE = 0x00000400,
        ALLOW_ENROLL_ON_BEHALF_OF = 0x00000800,
        ADD_OCSP_NOCHECK = 0x00001000,
        ENABLE_KEY_REUSE_ON_NT_TOKEN_KEYSET_STORAGE_FULL = 0x00002000,
        NOREVOCATIONINFOINISSUEDCERTS = 0x00004000,
        INCLUDE_BASIC_CONSTRAINTS_FOR_EE_CERTS = 0x00008000,
        ALLOW_PREVIOUS_APPROVAL_KEYBASEDRENEWAL_VALIDATE_REENROLLMENT = 0x00010000,
        ISSUANCE_POLICIES_FROM_REQUEST = 0x00020000,
        SKIP_AUTO_RENEWAL = 0x00040000
    }
}
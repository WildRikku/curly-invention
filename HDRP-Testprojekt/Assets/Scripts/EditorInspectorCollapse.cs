using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class ComponentTools {
    [MenuItem("CONTEXT/Component/Collapse All")]
    private static void CollapseAll() {
        SetAllInspectorsExpanded(false);
    }

    [MenuItem("CONTEXT/Component/Expand All")]
    private static void ExpandAll(MenuCommand command) {
        SetAllInspectorsExpanded(true);
    }

    private static void SetAllInspectorsExpanded(bool expanded) {
        var activeEditorTracker = ActiveEditorTracker.sharedTracker;

        for (var i = 0; i < activeEditorTracker.activeEditors.Length; i++) {
            activeEditorTracker.SetVisible(i, expanded ? 1 : 0);
        }
    }
}

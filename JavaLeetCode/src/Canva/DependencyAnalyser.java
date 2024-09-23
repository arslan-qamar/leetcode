package Canva;

import java.util.*;

public class DependencyAnalyser {

    public static ArrayList<String> findOrder(HashMap<String, ArrayList<String>> dependencies) {

        ArrayList<String> result = new ArrayList<>();

        HashSet<String> alreadyAdded = new HashSet<>();

        while(!dependencies.isEmpty()) {

            Map.Entry<String, ArrayList<String>> entry = dependencies.entrySet().stream().filter(e -> e.getValue().size() == 0).findFirst().get();

            if(entry != null && !alreadyAdded.contains(entry.getKey()) && entry.getValue().size() == 0)
            {
                alreadyAdded.add(entry.getKey());
                result.add(entry.getKey());
                removeDependency(entry.getKey(), dependencies);
                dependencies.remove(entry.getKey());
            }
        }

        return result;
    }

    private static void removeDependency(String key, HashMap<String, ArrayList<String>> dependencies) {

        for (Map.Entry<String, ArrayList<String>> entry : dependencies.entrySet())
        {
            if(entry.getValue().contains(key))
            {
                entry.getValue().remove(key);
            }
        }
    }
}

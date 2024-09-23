package Canva;

import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.HashMap;

import static org.assertj.core.api.Assertions.assertThat;


class DependencyAnalyserTest {

    @Test
    void findOrder() {
        //    input:
        //    {
        //        "pizza" : ["dough", "tomato"],
        //        "dough": [],
        //        "tomato": []
        //    }
        //    output: ["tomato", "dough", "pizza"] or ["dough", "tomato", "pizza"]

        HashMap<String, ArrayList<String>> dependencies = new HashMap<>();

        ArrayList<String> deps = new ArrayList<>();
        deps.add("dough");
        deps.add("tomato");

        dependencies.put("pizza", deps);

        ArrayList<String> doughDeps = new ArrayList<>();
        doughDeps.add("tomato");
        dependencies.put("dough", doughDeps);

        ArrayList<String> tomatoDeps = new ArrayList<>();
        dependencies.put("tomato", tomatoDeps);



        ArrayList<String> result = DependencyAnalyser.findOrder(dependencies);

        ArrayList<String> expectedresult = new ArrayList<String>();
        expectedresult.add("dough");
        expectedresult.add("tomato");
        expectedresult.add("pizza");

        assertThat(result).containsExactly("tomato", "dough", "pizza");
    }
}